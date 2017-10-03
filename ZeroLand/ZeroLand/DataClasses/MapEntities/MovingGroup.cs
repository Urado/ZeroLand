using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("MovingGroup")]
    class MovingGroup : GroupActors
    {
        public int Move { get; set; }
    }
}
