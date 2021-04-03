using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABintang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            string filename = "../../graph.txt";
            Input input = new Input(filename);
            Console.WriteLine("KAMUS:");
            foreach (var k in input.Kamus)
            {
                Console.Write(k.Value.Getname() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("TEMP_BRACKET:");
            foreach (var aa in input.temp_bracket)
            {
                foreach(var bb in aa)
                {
                    Console.Write(bb+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("BRACKET POINT:");
            foreach (var aaa in input.DataNode)
            {
                foreach (var bbb in aaa)
                {
                    Console.Write(bbb.Getname() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var x in input.hubungan)
            {
                foreach (var y in x)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
            Graph g = new Graph(input.Node);
            g.InputGraph(input.DataNode, input.Kamus);
            foreach(var x in g.adj)
            {
                foreach(var y in x)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
            List<double> hn = g.H_n(input.Kamus, g.TranslatetoPoint(input.Kamus, 0));
            foreach(var a in hn)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            List<Point> Solusi = g.ABintangShortestPath(input.Kamus, 
                g.TranslatetoPoint(input.Kamus, 0), g.TranslatetoPoint(input.Kamus, 2));
            for(int i = 0; i < Solusi.Count; i++)
            {
                Console.Write(Solusi[i].Getname());
                if (i != Solusi.Count - 1)
                {
                    Console.Write(" -> ");
                }

            }
            Console.WriteLine();
            Console.ReadKey();*/
        }
    }
}