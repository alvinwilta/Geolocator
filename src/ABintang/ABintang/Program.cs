using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

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
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\git\\IF2211_tucil3\\test\\Test.txt");
                //Write a line of text
                sw.WriteLine(Convert.ToString(input.Kamus.Count));
                foreach(var a in input.Kamus)
                {
                    sw.WriteLine(Convert.ToString(a.Value.Getlat() + " " + a.Value.Getlongt() + " " + a.Value.Getname()));

                }
                foreach (var x in input.hubungan)
                {
                    foreach(var y in x)
                    {
                        sw.Write(Convert.ToString(y + " "));
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            Console.ReadKey();*/
            
        }
    }
}