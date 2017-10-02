using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;

namespace ZeroLand.DataClasses
{
    class DataKeeper
    {
        public static DataKeeper Data = new DataKeeper();
        private DataKeeper()
        {
            Enitities = new List<BaseMapEnitity>();
            Actors = new List<Actor>();
            Resourses = new List<Resourse>();
            Keepers = new List<Keeper>();
        }
        public static void Init()
        {
            var neutral = new Keeper { Name = "Neutral" };
            var k1 = new Keeper { Name = "Nightwings" };
            Data.Keepers.AddRange(new List<Keeper> { neutral, k1 });

            var a1 = new Actor { Name = "Urado", ActorKeeper = k1 };
            var a2 = new Actor { Name = "Nakiva", ActorKeeper = k1 };
            var a3 = new Actor { Name = "Teltonia", ActorKeeper = k1 };
            Data.Actors.AddRange(new List<Actor> { a1, a2, a3 });
            k1.KeptActors.Add(a1);
            k1.KeptActors.Add(a2);
            k1.KeptActors.Add(a3);

            var t1 = new Town
            {
                Name = "Novigrad",
                Position = new Point { X = 0, Y = 0 },
                DetectingRadius = 100,
                CollisionRadius = 5,
                EnitityKeeper = k1
            };

            var army1 = new GroupActors
            {
                Name = "Wing of Hope",
                Position = new Point { X = 6, Y = 0 },
                DetectingRadius = 50,
                CollisionRadius = 1,
                EnitityKeeper = k1
            };

            var m1 = new Mine
            {
                Name = "Give Me Money beach",
                Position = new Point { X = 10, Y = -30 },
                DetectingRadius = 50,
                CollisionRadius = 2,
                EnitityKeeper = neutral
            };

            k1.KeptEnitity.Add(t1);
            k1.KeptEnitity.Add(army1);
            k1.KeptEnitity.Add(m1);

            Data.Enitities.AddRange(new List<BaseMapEnitity> { t1, army1, m1 });
        }
        public List<Keeper> Keepers { get; set; }
        public List<BaseMapEnitity> Enitities { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Resourse> Resourses { get; set; }
    }
}
