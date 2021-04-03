using System;
using System.Collections.Generic;
using System.Linq;

namespace ABintang
{
    class Graph
    {
        //Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
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

        /*/// <summary>
        ///Bertugas memberikan warna pada simpul yang akan ditunjuk ketika algoritma DFS digunakan
        /// </summary>
        public void ColorEdgeDFS(int v, int w, Dictionary<int, String> Kamus)
        {
            Microsoft.Msagl.Drawing.Node nv = graph.FindNode(Kamus[v]);
            Microsoft.Msagl.Drawing.Node nw = graph.FindNode(Kamus[w]);
            if (nv == null || nw == null) return;
            foreach (Microsoft.Msagl.Drawing.Edge e in nv.Edges)
            {
                if ((e.SourceNode == nv && e.TargetNode == nw) ||
                   (e.SourceNode == nw && e.TargetNode == nv))
                {
                    nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Orange;
                    nw.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Orange;
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    e.Attr.LineWidth = 4;
                    break;
                }
            }
        }
        /// <summary>
        ///Bertugas memberikan warna pada simpul yang akan ditunjuk ketika algoritma BFS digunakan
        /// </summary>
        public void ColorEdgeBFS(int v, int w, Dictionary<int, String> Kamus)
        {
            Microsoft.Msagl.Drawing.Node nv = graph.FindNode(Kamus[v]);
            Microsoft.Msagl.Drawing.Node nw = graph.FindNode(Kamus[w]);
            if (nv == null || nw == null) return;
            foreach (Microsoft.Msagl.Drawing.Edge e in nv.Edges)
            {
                if ((e.SourceNode == nv && e.TargetNode == nw) ||
                   (e.SourceNode == nw && e.TargetNode == nv))
                {
                    nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.GreenYellow;
                    nw.Attr.FillColor = Microsoft.Msagl.Drawing.Color.GreenYellow;
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    e.Attr.LineWidth = 4;
                    break;
                }
            }
        }

        /// <summary>
        /// Bertugas memberikan warna pada sudut yang akan ditunjuk
        /// </summary>
        public void ColorNode(int v, Dictionary<int, String> Kamus, String Warna)
        {
            Microsoft.Msagl.Drawing.Node nv = graph.FindNode(Kamus[v]);
            if (nv == null) return;
            if (Warna == "Orange")
            {
                nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Orange;
            }
            else if (Warna == "Green")
            {
                nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
            }
            else if (Warna == "YellowGreen")
            {
                nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.YellowGreen;
            }
            else if (Warna == "LightBlue")
            {
                nv.Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
            }
        }
        /// <summary>
        /// Mendapatkan Graph yang akan dipilih untuk digunakan lebih lanjut
        /// </summary>
        public Microsoft.Msagl.Drawing.Graph GetGraph()
        {
            return this.graph;
        }
        */
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
            /*Microsoft.Msagl.Drawing.Edge e = graph.AddEdge(Kamus[v], Kamus[w]);
            e.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
            e.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;*/
        }
        /// <summary>
        /// Menghitung jarak euclidian
        /// </summary>
        public double JarakEuclidian(Point a, Point b)
        {
            double dX = Math.Abs(a.Getlat() - b.Getlat());
            double dY = Math.Abs(a.Getlongt() - b.Getlongt());
            return (Math.Sqrt(dX * dX + dY * dY));
        }

        public Point TranslatetoPoint(Dictionary<int, Point> kamus, int x)
        {
            return kamus.ElementAt(x).Value;
        }
        public int TranslatetoInt(Dictionary<int, Point> kamus, Point y)
        {
            return kamus.FirstOrDefault(x => x.Value == y).Key;
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
            //List<Point> visited = new List<Point>();
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

                    /*foreach(var closed_child in close)
                    {
                        if (child == closed_child){
                            continue;
                        }
                    }*/

                    child.Setgn(adj[current_node.Getposition()][child.Getposition()]);
                    child.Sethn(hn[current_node.Getposition()]);
                    child.Setfn(child.Getgn() + child.Getfn());

                    /*foreach(var open_node in open)
                    {
                        if (child.Getposition() == open_node.Getposition() && child.Getgn() > open_node.Getgn())
                        {
                            continue;
                        }
                    }*/
                    if (open.Any(x => x.Getposition() == child.Getposition() && x.Getgn() > child.Getgn()))
                        continue;
                    
                    open.Add(child);
                }
            }
            //Tidak ketemu target
            return path2;
        }
        /*
        /// <summary>
        /// Algoritma Utama Bread First Search
        /// </summary>
        public Dictionary<int, int> BFS(List<int> BL, int v, int target, int node)
        {
            bool ketemu = false;
            Dictionary<int, int> prev = new Dictionary<int, int>();
            List<int> visited = new List<int>();

            // Buat Queue baru untuk BFS
            Queue<int> queue = new Queue<int>();

            //Kalau sudah dikunjungi, tambah ke list add
            visited.Add(v);
            if (!BL.Contains(v))
            {
                BL.Add(v);
            }
            queue.Enqueue(v);

            while (queue.Any())
            {
                if (queue.Peek() == target)
                {
                    ketemu = true;
                    break;
                }
                //Bangkitkan solusi antriannya
                int s = queue.Dequeue();

                if (!BL.Contains(s))
                {
                    BL.Add(s);
                }

                List<int> list = adj.ElementAt(s);

                foreach (var n in list)
                {
                    if (!visited.Contains(n) && list.Contains(n))
                    {
                        prev.Add(n, s);
                        visited.Add(n);
                        queue.Enqueue(n);
                    }
                }
            }
            if (!BL.Contains(target) && ketemu)
            {
                BL.Add(target);
            }
            else
            {
                BL.Clear();
            }
            return prev;
        }

        /// <summary>
        /// Algoritma Pembantu Depth First Search
        /// </summary>
        public void DFSUtil(List<int> AL, int v, List<int> visited,
            int target, List<List<int>> road_used, int parent, int it, int node, bool hapus)
        {
            int c = visited.Distinct().Count();

            // Kalau semua sudah dikunjungi, return saja;
            if (c == node || AL.Contains(target))
            {
                return;
            }
            if (AL.Count == 0 && hapus == true)
            {
                return;
            }

            //Tambahkan ke daftar dikunjungi
            if (!visited.Contains(v))
            {
                visited.Add(v);
            }
            road_used.Add(new List<int>() { parent, v });
            if (!AL.Contains(v) && hapus == false)
            {
                AL.Add(v);
            }

            List<int> vList = adj.ElementAt(v);
            for (int x = 0; x < node; x++)
            {
                // Panggil fungsi DFS apabila tidak dikunjungi
                if (!visited.Contains(x) && vList.Contains(x))
                {
                    hapus = false;
                    DFSUtil(AL, x, visited, target, road_used, v, it + 1, node, hapus);
                }
            }
            if (c == node || AL.Contains(target))
            {
                return;
            }
            for (int y = 0; y < road_used.Count; y++)
            {
                if (road_used[y][1] == v)
                {
                    hapus = true;
                    if (AL.Contains(v) && hapus == true)
                    {
                        AL.Remove(v);
                    }
                    DFSUtil(AL, road_used[y][0], visited, target, road_used, v, it + 1, node, hapus);
                }
            }
        }
        
        /// <summary>
        /// Algoritma Utama Depth First Search
        /// , akan dibantu rekursif dengan fungsi DFSUtil
        /// </summary>
        public Dictionary<int, List<int>> DFS(List<int> AL, int v, int target, int node)
        {
            Dictionary<int, List<int>> child = new Dictionary<int, List<int>>();
            List<int> visited = new List<int>();
            List<List<int>> road_used = new List<List<int>>();
            bool hapus = false;
            DFSUtil(AL, v, visited, target, road_used, -1, 0, node, hapus);
            foreach (var value in AL)
            {
                List<int> masuk = new List<int> { value };
                foreach (var x in adj[value])
                {
                    masuk.Add(x);
                }
                child.Add(value, masuk);
            }
            return child;
        }
        */

        /*
        /// <summary>
        /// Memberikan Rekomendasi Teman bagi sudut awal secara DFS
        /// </summary>
        public List<List<int>> RecommendDFS(int awal)
        {
            List<int> AL1 = new List<int>();
            List<List<int>> Bucket = new List<List<int>>();
            for (int i = 0; i < V; i++)
            {
                Bucket.Add(new List<int> { i });
                if (i != awal && !adj[awal].Contains(i))
                {
                    Dictionary<int, List<int>> hasil = DFS(AL1, awal, i, V);
                    if (hasil.Count > 0)
                    {
                        List<int> child = new List<int>();
                        child = hasil.First(x => x.Key == awal).Value;
                        List<int> child2 = hasil.FirstOrDefault(x => x.Key == i).Value;
                        IEnumerable<int> res = child.AsQueryable().Intersect(child2);
                        //Tambahkan friend recommendation
                        foreach (var masukkin in res)
                        {
                            Bucket.ElementAt(Bucket.Count - 1).Add(masukkin);
                        }
                    }
                }
                if (Bucket.ElementAt(Bucket.Count - 1).Count == 1)
                {
                    //Buang bracket di Count-1
                    Bucket.Remove(Bucket.ElementAt(Bucket.Count - 1));
                }
            }
            List<List<int>> NewBucket = Bucket.OrderByDescending(x => x.Count).ThenBy(x => x[1]).ToList();
            return NewBucket;
        }

        /// <summary>
        /// Memberikan Rekomendasi Teman bagi sudut awal secara BFS
        /// </summary>
        public List<List<int>> RecommendBFS(int awal)
        {
            //Komparasi 2 array hasil dfs first degree
            List<List<int>> Bucket = new List<List<int>>();

            Dictionary<int, int> previous = new Dictionary<int, int>();
            Dictionary<int, int> previous2 = new Dictionary<int, int>();
            for (int i = 0; i < V; i++)
            {
                if (i != awal && !adj[i].Contains(awal))
                {
                    List<int> arr1 = new List<int>();
                    List<int> arr2 = new List<int>();
                    Bucket.Add(new List<int>());
                    Bucket.ElementAt(Bucket.Count - 1).Add(i);
                    //Struktur:
                    //Huruf Rekomendasi: Mutual friend 1 - Mutual friend 2 - dll
                    previous = BFS(arr1, awal, i, V);
                    previous2 = BFS(arr2, i, awal, V);
                    List<int> List1 = previous.Where(x => x.Value == awal)
                      .Select(x => x.Key)
                      .ToList();
                    List<int> List2 = previous2.Where(x => x.Value == i)
                      .Select(x => x.Key)
                      .ToList();
                    IEnumerable<int> res = List1.AsQueryable().Intersect(List2);
                    foreach (var x in res)
                    {
                        if (x != awal && x != i)
                        {
                            Bucket.ElementAt(Bucket.Count - 1).Add(x);
                        }
                    }
                    if (Bucket.ElementAt(Bucket.Count - 1).Count == 1)
                    {
                        //Buang bracket di Count-1
                        Bucket.Remove(Bucket.ElementAt(Bucket.Count - 1));
                    }
                    List1.Clear();
                    List2.Clear();
                }
            }
            List<List<int>> NewBucket = Bucket.OrderByDescending(x => x.Count).ThenBy(x => x[1]).ToList();
            return NewBucket;
        }

        /// <summary>
        /// Eksplorasi Teman bagi sudut awal dan sudut target secara DFS
        /// </summary>
        public List<int> ExploreDFS(int awal, int akhir)
        {
            List<int> bracket = new List<int>();
            if (!adj[awal].Contains(akhir))
            {
                _ = DFS(bracket, awal, akhir, V);
            }
            else
            {
                bracket.Add(awal);
                bracket.Add(akhir);
            }
            return bracket;
        }

        /// <summary>
        /// Eksplorasi Teman bagi sudut awal dan sudut target secara BFS
        /// </summary>
        public List<int> ExploreBFS(int awal, int akhir)
        {
            Dictionary<int, int> prev = new Dictionary<int, int>();
            List<int> bracket = new List<int>();
            List<int> bracket2 = new List<int>();
            prev = BFS(bracket, awal, akhir, V);
            if (bracket.Count > 0)
            {
                int dari = bracket[bracket.Count - 1];
                while (dari != awal)
                {
                    bracket2.Add(dari);
                    dari = prev.FirstOrDefault(x => x.Key == dari).Value;
                }
                bracket2.Add(awal);
                bracket2.Reverse();
            }
            return bracket2;
        }
        */
        
    }
}