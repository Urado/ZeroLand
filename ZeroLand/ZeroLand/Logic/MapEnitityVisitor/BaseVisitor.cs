using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;
using ZeroLand.DataClasses;

namespace ZeroLand.Logic.MapEnitityVisitor
{
    class BaseVisitor : IMapEnitityVisitor
    {
        public DataKeeper Data { private get; set; }
        public void VisitBaseMapEnitity(BaseMapEnitity enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            Console.WriteLine("Remember");
        }

        public void VisitGroupActors(GroupActors enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            Console.WriteLine("Eat");
        }

        public void VisitMine(Mine enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            var newResorse = new List<Resourse>();   

            for(int i=0;i<enitity.Effectivity;i++)
            {
                newResorse.Add(new Resourse { ResourseType = enitity.MiningResourse });
            }

            Data.Resourses.AddRange(newResorse);
            newResorse.ForEach(r => enitity.Resourses.Add(r));

            Console.WriteLine("Give Money");
        }

        public void VisitMovingGroup(MovingGroup enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            var target = detectedEnitity.FirstOrDefault(e => (e is Mine && e.KeeperId != enitity.KeeperId))?.Position;
            if (target == null)
                target = new Point { X = enitity.Position.X + enitity.Move, Y = enitity.Position.Y + enitity.Move };

            double moovingRange; 

            moovingRange = (enitity.Move >= Point.Range(enitity.Position, target) - enitity.CollisionRadius) ?
                Point.Range(enitity.Position, target) - enitity.CollisionRadius : enitity.Move;

            Point vectorTo = Point.VectorTo(enitity.Position, target);

            enitity.Position.X += vectorTo.X * moovingRange;
            enitity.Position.Y += vectorTo.Y * moovingRange;

            Console.WriteLine("Moove");
        }

        public void VisitTown(Town enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            Console.WriteLine("Live");
        }
    }
}
