using System;
using System.Collections.Generic;
using System.Linq;

namespace ABintang
{
    class Graph
    {
        private int V; // Jumlah Node pada suatu graph

        //Struktur data Array of List
        public List<double>[] adj;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Graph(int v)
        {
            V = v;
            adj = new List<double>[v];
            for (int i = 0; i < v; ++i)
            {
                adj[i] = new List<double>();
                for(int j = 0; j < v; j++)
                {
                    adj[i].Add(0);
                }
            }
        }

        /// <summary>
        /// Fungsi untuk membuat graph dari input dan sort secara alphabetical agar terurut
        /// </summary>
        public void InputGraph(List<List<Point>> DataNode, Dictionary<int, Point> Kamus)
        {
            foreach (var line in DataNode)
            {
                AddEdge(Kamus.FirstOrDefault(x => x.Value == line[0]).Key, Kamus.FirstOrDefault(x => x.Value == line[1]).Key, Kamus);
            }
        }

        /// <summary>
        /// Fungsi untuk menambah simpul pada graf
        /// </summary>
        void AddEdge(int v, int w, Dictionary<int, Point> Kamus)
        {
            //JANGAN LUPA
            adj[v][w] = JarakEuclidian(TranslatetoPoint(Kamus,v), TranslatetoPoint(Kamus, w)); // Add w to v's list.
            adj[w][v] = JarakEuclidian(TranslatetoPoint(Kamus, v), TranslatetoPoint(Kamus, w)); // Add w to v's list.
        }
        /// <summary>
        /// Menghitung jarak Haversine (penghitungan anti-flat earther)
        /// </summary>
        public double JarakEuclidian(Point a, Point b)
        {
            //double dX = Math.Abs(a.Getlat() - b.Getlat());
            //double dY = Math.Abs(a.Getlongt() - b.Getlongt());
            //return (Math.Sqrt(dX * dX + dY * dY));

            double dLat = this.toRadian(b.Getlat() - a.Getlat());
            double dLon = this.toRadian(b.Getlongt() - a.Getlongt());
            double x = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
               Math.Cos(this.toRadian(a.Getlat())) * Math.Cos(this.toRadian(b.Getlat())) *
               Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(x)));
            double d = 6371 * c;

            return d;
        }
        /// <summary>
        /// Konversi double ke Radian
        /// </summary>
        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
        /// <summary>
        /// Konversi Integer ke Pointnya sesuai Kamus
        /// </summary>
        public Point TranslatetoPoint(Dictionary<int, Point> kamus, int x)
        {
            return kamus.ElementAt(x).Value;
        }
        /// <summary>
        /// Konversi Point ke Integernya sesuai Kamus
        /// </summary>
        public int TranslatetoInt(Dictionary<int, Point> kamus, Point y)
        {
            return kamus.FirstOrDefault(x => x.Value == y).Key;
        }
        public Point TranslatetoName(Dictionary<int, Point> kamus, string name)
        {
            Point p = new Point();
            foreach (var entry in kamus)
            {
                if (entry.Value.Getname()==name)
                {
                    p = entry.Value;
                    return p;
                }
            }
            return p;
        }

        /// <summary>
        /// Algoritma untuk membuat h(n) atau cost perkiraan ke tujuan
        /// </summary>
        public List<double> H_n(Dictionary<int,Point> kamus, Point target)
        {
            List<double> bracket = new List<double>();
            foreach(var line in kamus)
            {
                bracket.Add(JarakEuclidian(line.Value, target));
            }
            return bracket;
        }
        /// <summary>
        /// Algoritma utama A* shortest path
        /// </summary>
        public List<Point> ABintangShortestPath(Dictionary<int, Point> kamus, Point start, Point target)
        {
            Node start_node = new Node(9999, TranslatetoInt(kamus, start));
            Node end_node = new Node(9999, TranslatetoInt(kamus, target));
            //inisialisasi list h(n)
            List<double> hn = H_n(kamus, target);
            //Inisialisasi Node Open dan Close
            List<Node> open = new List<Node>();
            List<Node> close = new List<Node>();
            List<Point> path2 = new List<Point>();
            open.Add(start_node);
            while (open.Count > 0)
            {
                Node current_node = open[0];
                foreach(Node n in open)
                {
                    if (n.Getfn() < current_node.Getfn())
                    {
                        current_node = n;
                    }
                }

                close.Add(current_node);
                open.Remove(current_node);

                //Kalau targetnya ketemu
                if (current_node == end_node)
                {
                    List<int> path = new List<int>();
                    int current = current_node.Getposition();
                    while (current != 9999)
                    {
                        path.Add(current);
                        current = current_node.Getparent();
                        foreach (Node x in close)
                        {
                            //Console.WriteLine(x.Getposition());
                            if (x.Getposition() == current_node.Getparent() && current != 9999)
                            {
                                current_node = x;
                            }
                        }
                    }
                    Console.WriteLine("length path :" + path.Count);
                    path.Reverse();
                    for(int i=0; i < path.Count; i++)
                    {
                         path2.Add(TranslatetoPoint(kamus, path[i]));
                    }
                    return path2;
                }

                List<Node> children = new List<Node>();
                for (int i = 0; i < V; i++)
                {
                    if(adj[current_node.Getposition()][i] != 0){
                        Node new_node = new Node(current_node.Getposition(), i);
                        children.Add(new_node);
                    }
                }

                foreach (var child in children)
                {
                    if (close.Any(x => x.Getposition() == child.Getposition()))
                        continue;

                    child.Setgn(adj[current_node.Getposition()][child.Getposition()]);
                    child.Sethn(hn[current_node.Getposition()]);
                    child.Setfn(child.Getgn() + child.Getfn());

                    //Apabila simpul anak ternyata sudah ada di list Open dan g(n) x lebih besar dari g(n) simpul anaknya
                    if (open.Any(x => x.Getposition() == child.Getposition() && x.Getgn() > child.Getgn()))
                        continue;
                    
                    open.Add(child);
                }
            }
            //Tidak ketemu target
            return path2;
        }
        /// <summary>
        /// Algoritma untuk menghitung jarak dari simpul awal ke simpul tujuan A*
        /// </summary>
        public double HitungJarak(Dictionary<int,Point> kamus, List<Point> path)
        {
            double jarak = 0;
            for(int i = 0; i < path.Count-1; i++)
            {
                jarak += adj[TranslatetoInt(kamus, path[i])][TranslatetoInt(kamus, path[i+1])];
            }
            return jarak;
        } 
    }
}