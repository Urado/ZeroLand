using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses;
using ZeroLand.DataClasses.MapEntities;
using ZeroLand.Logic.MapEnitityVisitor;

namespace ZeroLand.Logic
{
    class ZeroLandMainLogic
    {
        private IMapEnitityVisitor _visitor= new BaseVisitor();

        public void OutNow()
        {
            using (var Data = new DataKeeper())
            {
                foreach (var a in Data.Keepers)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();
                foreach (var a in Data.Actors)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();
                foreach (var a in Data.Enitities)
                {
                    //Console.WriteLine("{0} {1} {2} {3} {4}", a.GetType().ToString(), a.Name, a.EnitityKeeper.Name, a.Position.X, a.Position.Y);
                    Console.WriteLine(a.ToString());
                }
            }
        }


        public void OneTact()
        {
            Console.WriteLine("Doo tact");
            var keepers = new List<Keeper>();
            var allEnitities = new List<BaseMapEnitity>();

            using (var data = new DataKeeper())
            {
                keepers.AddRange(data.Keepers);
                allEnitities.AddRange(data.Enitities);

                foreach (var keeper in keepers)
                {
                    var keepresEnitity = new List<BaseMapEnitity>();
                    var detectedEnitity = new HashSet<BaseMapEnitity>();
                    var collisionEnitity = new HashSet<BaseMapEnitity>();

                    keepresEnitity.AddRange(allEnitities.Where(e => e.EnitityKeeper.KeeperId == keeper.KeeperId));
                    foreach (var enitity in keepresEnitity)
                    {
                        foreach (var detected in allEnitities.Where(e => enitity.IsDetected(e) && e.KeeperId != keeper.KeeperId))
                            detectedEnitity.Add(detected);
                        foreach (var Collided in allEnitities.Where(e => enitity.IsCollided(e) && e.KeeperId != keeper.KeeperId))
                            collisionEnitity.Add(Collided);
                    }

                    foreach (var o in keepresEnitity)
                    {
                        o.Visit(_visitor, detectedEnitity);
                    }

                    /*
                    foreach (var o in keepresEnitity)
                    {
                        o.Visit(_visitor, detectedEnitity);
                        Console.WriteLine("\n"+o.ToString() + "\n\n");
                    }
                    Console.WriteLine();
                    foreach (var o in detectedEnitity)
                        Console.WriteLine(o.ToString() + "\n");
                    Console.WriteLine();
                    foreach (var o in collisionEnitity)
                        Console.WriteLine(o.ToString() + "\n");
                    Console.WriteLine();

                    Console.WriteLine();
                    */
                }
                data.SaveChanges();
            }
        }
    }
}
