using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ZeroLand.DataClasses.MapEntities
{
    public abstract class BaseMapEnitity
    {
        public int Id { get; set; }

        public double CollisionRadius { get; set; }

        public double DetectingRadius { get; set; }

        public Point Position { get; set; }

        public string Name { get; set; }

        public int KeeperId { get; set; }

        public Keeper EnitityKeeper { get; set; }

        public bool IsDetected(BaseMapEnitity enitity)
        {
            return Sqrt(Pow(Position.X - enitity.Position.X, 2) + Pow(Position.Y - enitity.Position.Y, 2)) <= DetectingRadius + enitity.CollisionRadius;
        }

        public bool IsCollided(BaseMapEnitity enitity)
        {
            return Sqrt(Pow(Position.X - enitity.Position.X, 2) + Pow(Position.Y - enitity.Position.Y, 2)) <= CollisionRadius + enitity.CollisionRadius;
        }

        private const string _format = "{0}\nPosishon:\n{1}\nRadius: {2} Detect radius: {3}\nKeeper:\n{4}\n";

        public override string ToString()
        {
            return string.Format(_format, Name, Position, CollisionRadius, DetectingRadius,EnitityKeeper.Name);
        }
    }
}
