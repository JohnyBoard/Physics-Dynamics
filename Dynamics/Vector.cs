using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics
{
    public class Vector
    {

        //IA changing
        public Vector() : this(0, 0) { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector Projection(Vector v)
        {
            return this * v / v.SquareAbs * v;
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a + -b;
        }

        public static Vector operator *(Vector v, double n)
        {
            return new Vector(v.X * n, v.Y * n);
        }

        public static Vector operator /(Vector v, double n)
        {
            return v * (1 / n);
        }

        public static Vector operator *(double n, Vector v)
        {
            return v * n;
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double SquareAbs
        {
            get
            {
                return X * X + Y * Y;
            }
        }

        public double Abs
        {
            get
            {
                return Convert.ToInt32(Math.Round(Math.Sqrt(SquareAbs)));
            }
        }

        public Vector GetNorm()
        {
            return new Vector(-Y, X);
        }

        public Vector Mirror(Vector v)
        {
            return this - 2 * this.Projection(v.GetNorm());
        }
    }
}