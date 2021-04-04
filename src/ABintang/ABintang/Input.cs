using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace ABintang{
    class Input
    {
        public Dictionary<int, Point> Kamus;
        public List<List<Point>> DataNode;
        public int Node;
        public List<List<String>> Data;
        public List<List<int>> hubungan;
        public List<List<string>> temp_bracket;
        /// <summary>
        /// Konstruktor berparameter filename
        /// </summary>
        public Input(string filename)
        {
            Data = FileInput(filename); //list berisi string point
            DataNode = FilePoint(Data); //list berisi point source ke point target
            Kamus = KamusData(DataNode); //Kamus berisi integer dan poinnya
            Node = Kamus.Count;
        }
        /// <summary>
        /// Menghasilkan List of string berisi data point dalam string
        /// </summary>
        private List<List<string>> FileInput(string filename)
        {
            List<List<string>> bracket = new List<List<string>>();
            temp_bracket = new List<List<string>>();
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(filename);
            hubungan = new List<List<int>>();
            // Display the file contents by using a foreach loop.
            int i = 0;
            int jumlah_node = 0;
            foreach (string line in lines)
            {
                if (i != 0)
                {
                    if (i > jumlah_node)
                    {
                        List<string> line2 = line.Split(' ').ToList();
                        List<int> baris = line2.Select(s => Convert.ToInt32(s)).ToList();
                        hubungan.Add(baris);
                        i++;
                    }
                    else
                    {
                        List<string> line2 = line.Split(' ').ToList();
                        temp_bracket.Add(line2);
                        i++;
                    }
                }
                else
                {
                    jumlah_node = Convert.ToInt32(line);
                    i++;
                }
                // Use a tab to indent each line of the file.
            }
            for (int a = 0; a < hubungan.Count; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    if (hubungan[a][b] == 1)
                    {
                        var row = new List<string>();
                        row.Add(temp_bracket[b][0]);
                        row.Add(temp_bracket[b][1]);
                        row.Add(temp_bracket[b][2]);
                        row.Add(temp_bracket[a][0]);
                        row.Add(temp_bracket[a][1]);
                        row.Add(temp_bracket[a][2]);
                        bracket.Add(row);
                    }
                }
            }
            return bracket;
        }
        /// <summary>
        /// Menghasilkan List of Point berisi data point dalam Kelas Point
        /// </summary>
        private List<List<Point>> FilePoint(List<List<string>> fileinput)
        {
            List<List<Point>> bracket = new List<List<Point>>();
            foreach(var line in fileinput)
            {
                List<Point> listofpoint = new List<Point>();
                Point source = new Point(Convert.ToDouble(line[0], CultureInfo.InvariantCulture), Convert.ToDouble(line[1], CultureInfo.InvariantCulture), line[2]);
                Point target = new Point(Convert.ToDouble(line[3], CultureInfo.InvariantCulture), Convert.ToDouble(line[4], CultureInfo.InvariantCulture), line[5]);
                listofpoint.Add(source);
                listofpoint.Add(target);
                bracket.Add(listofpoint);
            }
            return bracket;
        }
        /// <summary>
        /// Mengecek apakah terdapat suatu Point di dalam list of Point
        /// </summary>
        private bool Contains(List<Point>bahanbaku, Point line)
        {
            foreach(var x in bahanbaku)
            {
                if (x == line)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Menghasilkan Map berisi korelasi antara integer dan Point
        /// </summary>
        private Dictionary<int, Point> KamusData(List<List<Point>> bracket)
        {
            List<Point> bahanbaku = new List<Point>();
            foreach (var line in bracket)
            {
                if (!Contains(bahanbaku, line[0]))
                {
                    //Cek apakah elemen ke 0 dari tiap line sudah ada di bahanbaku
                    bahanbaku.Add(line[0]);
                }
                if (!Contains(bahanbaku, line[1]))
                {
                    //Cek apakah elemen ke 1 dari tiap line sudah ada di bahanbaku
                    bahanbaku.Add(line[1]);
                }
            }
            //Himpunan bahanbaku sudah siap
            //Masukkan jumlah node ke variabel static global node

            /*Tahap Pembuatan Dictionary*/
            Dictionary<int, Point> kamus = new Dictionary<int, Point>();
            int i = 0;
            foreach (var elemen in bahanbaku)
            {
                kamus.Add(i, elemen);
                i++;
            }
            return kamus;
        }

        public Point GetMiddleCoords()
        {
            Double maxlat = Kamus.First().Value.Getlat();
            Double maxlongt = Kamus.First().Value.Getlongt();
            Double minlat = Kamus.First().Value.Getlat();
            Double minlongt = Kamus.First().Value.Getlongt();
            foreach (var entry in Kamus)
            {
                if (entry.Value.Getlat() > maxlat) { maxlat = entry.Value.Getlat(); }
                if (entry.Value.Getlongt() > maxlongt) { maxlongt = entry.Value.Getlongt(); }
                if (entry.Value.Getlat() < minlat) { minlat = entry.Value.Getlat(); }
                if (entry.Value.Getlongt() < minlongt) { minlongt = entry.Value.Getlongt(); }
            }
            Double lat = minlat + (maxlat - minlat)/2;
            Double longt = minlongt + (maxlongt - minlongt)/2;
            Point temp = new Point(lat, longt, "COORDS");
            return temp;
        }
    }
}