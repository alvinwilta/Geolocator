using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ABintang
{
    class Output
    {
        public void Maketxt (Input input, string filename)
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter(filename);
            //Write a line of text
            sw.WriteLine(Convert.ToString(input.Kamus.Count));
            foreach (var a in input.Kamus)
            {
                sw.WriteLine(Convert.ToString(a.Value.Getlat() + " " + a.Value.Getlongt() + " " + a.Value.Getname()));

            }
            foreach (var x in input.hubungan)
            {
                foreach (var y in x)
                {
                    sw.Write(Convert.ToString(y + " "));
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
