using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyComplex(3, 4);
            var c2 = new MyComplex(4, 3);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
        }
    }

    class MyComplex
    {
        private double re, im;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public MyComplex(double xre, double xim) { re = xre; im = xim; }
        
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re - 1, mc.im - 1); }

        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.re + 1, mc.im + 1); }

        public double Mod() { return Math.Abs(re * re + im * im); }

        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }

        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public static MyComplex operator +(MyComplex c1, MyComplex c2)
        {
            return new MyComplex(c1.re + c2.re, c1.im + c2.im);
        }
        public static MyComplex operator -(MyComplex c1, MyComplex c2)
        {
            return new MyComplex(c1.re - c2.re, c1.im - c2.im);
        }
        public static MyComplex operator *(MyComplex c1, MyComplex c2)
        {
            return new MyComplex(c1.re*c2.re - c1.im*c2.im, c1.im*c2.re + c2.im*c1.re);
        }
        public static MyComplex operator /(MyComplex c1, MyComplex c2)
        {
            double a = c1.re;
            double b = c1.im;
            double c = c2.re;
            double d = c2.im;
            return new MyComplex((a*c + b*d) / (c*c + d*d),
                (b*c - a*d) / (c*c + d*d));
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
