using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroLand.DataClasses
{
    public class Point
    {
        private const string _format = "{0} {1}";
        public double X { get; set; }
        public double Y { get; set; }
        public static double Range(Point From, Point To)
        {
            return Math.Sqrt(Math.Pow(From.X - To.X, 2) + Math.Pow(From.Y - To.Y, 2));
        }

        public static Point VectorTo(Point From,Point To)
        {
            Point ret = new Point()
            {
                X = To.X - From.X,
                Y = To.X - From.Y
            };
            ret.Normalizade();
            return ret;
        }

        private void Normalizade()
        {
            double Norm = Math.Sqrt(X * X + Y * Y);
            X /= Norm;
            Y /= Norm;
        }

        public override string ToString()
        {
            return string.Format(_format, X, Y);
        }
    }
}
