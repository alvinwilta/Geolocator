using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABintang
{
    class Point
    {
        private double lat;
        private double longt;
        private string name;

        public Point()
        {
            lat = 0;
            longt = 0;
            name = "NONAME";
        }
        public Point(double lat, double longt, string name)
        {
            this.lat = lat;
            this.longt = longt;
            this.name = name;
        }
        public double Getlat()
        {
            return lat;
        }
        public double Getlongt()
        {
            return longt;
        }
        public string Getname()
        {
            return name;
        }
        public void Setlat(double _lat)
        {
            lat = _lat;
        }
        public void Setlongt(double _longt)
        {
            longt = _longt;
        }
        public void Setname(string _name)
        {
            name = _name;
        }
        public static bool operator == (Point p1, Point p2)
        {  
            return (p1.lat == p2.lat && p1.longt == p2.longt && p1.name == p2.name);  
        }
        public static bool operator != (Point p1, Point p2)
        {
            return (p1.lat!=p2.lat || p1.longt != p2.longt || p1.name != p2.name);
        }
        public bool Equals(Point p2)
        {
            return (this.lat == p2.lat && this.longt == p2.longt && this.name == p2.name);
        }
    }
}
