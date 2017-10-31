using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ZeroLand.Logic.MapEnitityVisitor;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("Mine")]
    public class Mine : GroupActors
    {

        public ResourseTypes MiningResourse { get; set; }

        public int Effectivity { get; set; }

        public override void Visit(IMapEnitityVisitor visitor, ICollection<BaseMapEnitity> detected)
        {
            visitor.VisitMine(this, detected);
            base.Visit(visitor, detected);
        }

        private const string _format = "Mine\n{0}";
        public override string ToString()
        {
            return string.Format(_format, base.ToString());
        }
    }
}
