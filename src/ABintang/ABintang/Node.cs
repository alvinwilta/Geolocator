using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABintang
{
    class Node
    {
        private int parent;
        private int position;
        private double gn;
        private double hn;
        private double fn;

        public Node()
        {
            parent = -1;
            position = -1;
            gn = 0;
            hn = 0;
            fn = 0;
        }
        public Node(int _parent, int _position)
        {
            parent = _parent;
            position = _position;
            gn = 0;
            hn = 0;
            fn = 0;
        }
        public int Getparent()
        {
            return parent;
        }
        public int Getposition()
        {
            return position;
        }
        public double Getgn()
        {
            return gn;
        }
        public double Gethn()
        {
            return hn;
        }
        public double Getfn()
        {
            return fn;
        }
        public void Setparent(int _parent)
        {
            parent = _parent;
        }
        public void Setposition(int _position)
        {
            position = _position;
        }
        public void Setgn(double _gn)
        {
            gn = _gn;
        }
        public void Sethn(double _hn)
        {
            hn = _hn;
        }
        public void Setfn(double _fn)
        {
            fn = _fn;
        }
        public static bool operator == (Node n1, Node n2)
        {
            return (n1.position == n2.position);
        }
        public static bool operator !=(Node n1, Node n2)
        {
            return (n1.position != n2.position);
        }
        public bool Equals (Node n2)
        {
            return (this.position == n2.position);
        }
    }
}
