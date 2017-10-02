using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ZeroLand.DataClasses.MapEntities
{
    public class BaseMapEnitity
    {
        public double CollisionRadius { get; set; }

        public double DetectingRadius { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public string Name { get; set; }

        public bool IsDetected(BaseMapEnitity enitity)
        {
            return Sqrt(Pow(X - enitity.X, 2) + Pow(Y - enitity.Y, 2)) <= DetectingRadius + enitity.CollisionRadius;
        }

        public bool IsCollided(BaseMapEnitity enitity)
        {
            return Sqrt(Pow(X - enitity.X, 2) + Pow(Y - enitity.Y, 2)) <= CollisionRadius + enitity.CollisionRadius;
        }
    }
}
