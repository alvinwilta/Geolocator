using System;
using System.Collections.Generic;
using System.Linq;

namespace ABintang{
    class Input
    {
        public Dictionary<int, Point> Kamus;
        public List<List<Point>> DataNode;
        public int Node;
        public List<List<String>> Data;
        public Input(string filename)
        {
            Data = FileInput(filename); //list berisi string point
            DataNode = FilePoint(Data); //list berisi point source ke point target
            Kamus = KamusData(DataNode); //Kamus berisi integer dan poinnya
            Node = Kamus.Count;
        }
        private List<List<string>> FileInput(string filename)
        {
            List<List<string>> bracket = new List<List<string>>();
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(filename);

            // Display the file contents by using a foreach loop.
            int i = 0;
            foreach (string line in lines)
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    List<string> line2 = line.Split(' ').ToList();
                    bracket.Add(line2);
                    i++;
                }
                // Use a tab to indent each line of the file.
            }
            return bracket;
        }

        private List<List<Point>> FilePoint(List<List<string>> fileinput)
        {
            List<List<Point>> bracket = new List<List<Point>>();
            foreach(var line in fileinput)
            {
                List<Point> listofpoint = new List<Point>();
                Point source = new Point(Convert.ToDouble(line[0]), Convert.ToDouble(line[1]), line[2]);
                Point target = new Point(Convert.ToDouble(line[3]), Convert.ToDouble(line[4]), line[5]);
                listofpoint.Add(source);
                listofpoint.Add(target);
                bracket.Add(listofpoint);
            }
            return bracket;
        }
        /*private static bool SudahAda(List<Point>listofpoint, Point p)
        {
            bool found = false;
            foreach(var line in listofpoint)
            {
                if(line == p)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }*/
        private Dictionary<int, Point> KamusData(List<List<Point>> bracket)
        {
            List<Point> bahanbaku = new List<Point>();
            foreach (var line in bracket)
            {
                if (!bahanbaku.Contains(line[0]))
                {
                    //Cek apakah elemen ke 0 dari tiap line sudah ada di bahanbaku
                    bahanbaku.Add(line[0]);
                }
                if (!bahanbaku.Contains(line[1]))
                {
                    //Cek apakah elemen ke 1 dari tiap line sudah ada di bahanbaku
                    bahanbaku.Add(line[1]);
                }
            }
            //Himpunan bahanbaku sudah siap
            //Masukkan jumlah node ke variabel static global node
            //bahanbaku.Sort();

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
    }
}