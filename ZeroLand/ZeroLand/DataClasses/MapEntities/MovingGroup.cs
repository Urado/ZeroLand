using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ZeroLand.Logic.MapEnitityVisitor;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("MovingGroup")]
    public class MovingGroup : GroupActors
    {

        public int Move { get; set; }

        public override void Visit(IMapEnitityVisitor visitor, ICollection<BaseMapEnitity> detected)
        {
            visitor.VisitMovingGroup(this,detected);
            base.Visit(visitor, detected);
        }

        private const string _format = "MovingGroup\n{0}";
        public override string ToString()
        {
            return string.Format(_format, base.ToString());
        }
    }
}
