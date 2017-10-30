using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;

namespace ZeroLand.Logic.MapEnitityVisitor
{
    public interface IMapEnitityVisitor
    {
        void VisitBaseMapEnitity(BaseMapEnitity enitity, ICollection<BaseMapEnitity> detectedEnitity);
        void VisitGroupActors(GroupActors enitity, ICollection<BaseMapEnitity> detectedEnitity);
        void VisitMine(Mine enitity, ICollection<BaseMapEnitity> detectedEnitity);
        void VisitMovingGroup(MovingGroup enitity, ICollection<BaseMapEnitity> detectedEnitity);
        void VisitTown(Town enitity, ICollection<BaseMapEnitity> detectedEnitity);
    }
}
