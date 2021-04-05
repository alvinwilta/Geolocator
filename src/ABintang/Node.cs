namespace ABintang
{
    /// <summary>
    /// Node untuk mengandung properti dari A* berupa g(n), h(n), dan f(n)
    /// </summary>
    class Node
    {
        private int parent;
        private int position;
        private double gn;
        private double hn;
        private double fn;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Node()
        {
            parent = 9999;
            position = 9999;
            gn = 0;
            hn = 0;
            fn = 0;
        }
        /// <summary>
        /// Konstruktor berparameter parent dan pointnya
        /// </summary>
        public Node(int _parent, int _position)
        {
            parent = _parent;
            position = _position;
            gn = 0;
            hn = 0;
            fn = 0;
        }
        //getter
        public int Getparent(){return parent;}
        public int Getposition(){return position;}
        public double Getgn(){return gn;}
        public double Gethn(){return hn;}
        public double Getfn(){return fn;}
        //setter
        public void Setparent(int _parent){parent = _parent;}
        public void Setposition(int _position){position = _position;}
        public void Setgn(double _gn){gn = _gn;}
        public void Sethn(double _hn){hn = _hn;}
        public void Setfn(double _fn){fn = _fn;}
        //operator overloading
        public static bool operator == (Node n1, Node n2){return (n1.position == n2.position);}
        public static bool operator !=(Node n1, Node n2){return (n1.position != n2.position);}
        public bool Equals (Node n2){return (this.position == n2.position);}
    }
}
