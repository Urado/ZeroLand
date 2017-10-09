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
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return string.Format(_format, X, Y);
        }
    }
}
