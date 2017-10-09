using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Threading;
using ZeroLand.DataClasses.MapEntities;

namespace ZeroLand.DataClasses
{
    class DataKeeper : DbContext
    {
        public static Mutex KeeperMutex = new Mutex();
        public DataKeeper() : base("ZeroLand.Properties.Settings.DataBaseZeroLandConnectionString")
        {
            KeeperMutex.WaitOne();
        }
        public static void Init()
        {
            using (var Data = new DataKeeper())
            {
                var neutral = new Keeper { Name = "Neutral" };
                var k1 = new Keeper { Name = "Nightwings" };
                Data.Keepers.AddRange(new List<Keeper> { neutral, k1 });
                Data.SaveChanges();

                var a1 = new Actor { Name = "Urado", ActorKeeper = k1 };
                var a2 = new Actor { Name = "Nakiva", ActorKeeper = k1 };
                var a3 = new Actor { Name = "Teltonia", ActorKeeper = k1 };
                Data.Actors.AddRange(new List<Actor> { a1, a2, a3 });
                k1.KeptActors.Add(a1);
                k1.KeptActors.Add(a2);
                k1.KeptActors.Add(a3);
                Data.SaveChanges();

                var t1 = new Town
                {
                    Name = "Novigrad",
                    Position = new Point { X = 0, Y = 0 },
                    DetectingRadius = 100,
                    CollisionRadius = 5,
                    EnitityKeeper = k1
                };
                t1.Actors.Add(a1);

                var army1 = new MovingGroup
                {
                    Name = "Wing of Hope",
                    Position = new Point { X = 6, Y = 0 },
                    DetectingRadius = 50,
                    CollisionRadius = 1,
                    EnitityKeeper = k1,
                    Move = 1
                };
                army1.Actors.Add(a2);
                army1.Actors.Add(a3);

                var m1 = new Mine
                {
                    Name = "Give Me Money beach",
                    Position = new Point { X = 10, Y = -30 },
                    DetectingRadius = 50,
                    CollisionRadius = 2,
                    EnitityKeeper = neutral
                };
                Data.Enitities.AddRange(new List<BaseMapEnitity> { t1, army1, m1 });
                k1.KeptEnitity.Add(t1);
                k1.KeptEnitity.Add(army1);
                k1.KeptEnitity.Add(m1);


                Data.SaveChanges();
            }

            using (var Data = new DataKeeper())
            {
                foreach(var a in Data.Keepers)
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
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            KeeperMutex.ReleaseMutex();
        }

        public DbSet<Keeper> Keepers { get; set; }
        public DbSet<BaseMapEnitity> Enitities { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Resourse> Resourses { get; set; }
    }
}
