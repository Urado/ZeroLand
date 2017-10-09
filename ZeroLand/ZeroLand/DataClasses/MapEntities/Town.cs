using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ZeroLand.Logic.MapEnitityVisitor;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("Town")]
    public class Town : GroupActors
    {
        public int Class { get; set; }

        public override void Visit(IMapEnitityVisitor visitor, ICollection<BaseMapEnitity> detected)
        {
            visitor.VisitTown(this, detected);
            base.Visit(visitor, detected);
        }

        private const string _format = "Town\n{0}";
        public override string ToString()
        {
            return string.Format(_format,base.ToString());
        }
    }
}
