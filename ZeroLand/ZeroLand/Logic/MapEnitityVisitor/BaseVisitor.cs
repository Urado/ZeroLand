using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;

namespace ZeroLand.Logic.MapEnitityVisitor
{
    class BaseVisitor : IMapEnitityVisitor
    {
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
            Console.WriteLine("Give Money");
        }

        public void VisitMovingGroup(MovingGroup enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            Console.WriteLine("Moove");
        }

        public void VisitTown(Town enitity, ICollection<BaseMapEnitity> detectedEnitity)
        {
            Console.WriteLine("Live");
        }
    }
}
