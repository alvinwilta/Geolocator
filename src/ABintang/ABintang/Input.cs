using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace ABintang{
    class Input
    {
        public Dictionary<int, Point> Kamus;
        public List<List<Point>> DataNode;
        public int nodeinp;
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
            nodeinp = Kamus.Count;
        }
        public Input()
        {
            Data = new List<List<string>>();
            hubungan = new List<List<int>>();
            DataNode = new List<List<Point>>();
            nodeinp = 0;
            Kamus = new Dictionary<int, Point>();
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
            foreach (var line in fileinput)
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
        private bool Contains(List<Point> bahanbaku, Point line)
        {
            foreach (var x in bahanbaku)
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
            Double lat = minlat + (maxlat - minlat) / 2;
            Double longt = minlongt + (maxlongt - minlongt) / 2;
            Point temp = new Point(lat, longt, "COORDS");
            return temp;
        }

        /// <summary>
        /// Check if there is duplicate of name in Kamus
        /// </summary>
        /// <param name="name"></param>
        /// <returns> True if exists duplicate, else false </returns>
        public Boolean CheckDuplName(string name)
        {
            if (Kamus.Count() > 0)
            {
                foreach (var entry in Kamus)
                {
                    if (entry.Value.Getname() == name) { return true; }
                }
            }
            return false;
        }

        public void AddKamusData(double lat, double lng, string name)
        {
            Point temp = new Point(lat, lng, name);
            Kamus.Add(nodeinp, temp);
            if (nodeinp == 0)
            {
                List<int> temp2 = new List<int>();
                temp2.Add(0); 
                hubungan.Add(temp2);
            }
            else //kalau node > 0
            {
                List<int> temp2 = new List<int>();
                for (int i = 0; i < nodeinp; i++)
                {
                    hubungan[i].Add(0);
                    temp2.Add(0);
                }
                temp2.Add(0);
                hubungan.Add(temp2);
            }
            nodeinp++;
        }
        /// <summary>
        /// Membersihkan class input
        /// </summary>
        public void ClearInputClass()
        {
            Kamus.Clear();
            DataNode.Clear();
            nodeinp = 0;
            Data.Clear();
            hubungan.Clear();
        }
        /// <summary>
        /// Print adjacency Matrix
        /// </summary>
        /// <returns> string with newline, contents of adj matrix </returns>
        public string CheckAdjMatrix()
        {
            string temp = "";
            foreach (var x in Kamus)
            {
                temp += x.Value.Getname();
                temp += " ";
            }
            temp += "\n";
            foreach (var x in hubungan)
            {
                foreach (var y in x)
                {
                    temp += y;
                    temp += " ";
                }
                temp += "\n";
            }
            return temp;
        }
        /// <summary>
        /// Mengecek apakah terdapat sisi diantara 2 node
        /// </summary>
        /// <param name="a">nama node 1</param>
        /// <param name="b">nama node 2</param>
        /// <returns>jika ada true, else false</returns>
        public Boolean IsSisiAda(string a, string b)
        {
            int n1 = Kamus.FirstOrDefault(x => x.Value.Getname() == a).Key;
            int n2 = Kamus.FirstOrDefault(x => x.Value.Getname() == b).Key;
            if (hubungan[n1][n2]==1) { return true; }
            return false;
        }
        public void AddSisi(string a, string b)
        {
            int n1 = Kamus.FirstOrDefault(x => x.Value.Getname() == a).Key;
            int n2 = Kamus.FirstOrDefault(x => x.Value.Getname() == b).Key;
            hubungan[n1][n2] = 1;
            hubungan[n2][n1] = 1;
        }
        public List<List<int>> IterasiAdjList()
        {
            List<List<int>> retval = new List<List<int>>();
            List<int> temp;
            for (int i=0; i<nodeinp; i++)
            {
                for (int j=nodeinp-1; j>i; j--)
                {
                    temp = new List<int>();
                    if (hubungan[i][j] == 1)
                    {
                        temp.Add(i);
                        temp.Add(j);
                        retval.Add(temp);
                    }
                }
            }
            return retval;
        }
    }
}
