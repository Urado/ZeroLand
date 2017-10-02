using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;
using ZeroLand.DataClasses;

namespace ZeroLand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseMapEnitity> TestList = new List<BaseMapEnitity> {
                new BaseMapEnitity { X = 0, Y = 0, DetectingRadius = 10, CollisionRadius = 1 },
                new BaseMapEnitity { X = 1000, Y = 1000, DetectingRadius = 10, CollisionRadius = 1 },
                new BaseMapEnitity { X = 5, Y = 5, DetectingRadius = 10, CollisionRadius = 1 },
                new BaseMapEnitity { X = 1, Y = 0, DetectingRadius = 10, CollisionRadius = 1 },
                new BaseMapEnitity { X = -9, Y = 11, DetectingRadius = 10, CollisionRadius = 1 } };

            DataKeeper.Data.Enitities.AddRange(TestList);

            var DetectedEnitity = TestList.Where(e => e.IsDetected(TestList[0]));
            var CollidedEnitity = TestList.Where(e => e.IsCollided(TestList[0]));

            foreach(var e in DetectedEnitity)
            {
                Console.WriteLine("{0} {1}", e.X, e.Y);
            }
            Console.WriteLine();
            foreach (var e in CollidedEnitity)
            {
                Console.WriteLine("{0} {1}", e.X, e.Y);
            }
        }
    }
}
