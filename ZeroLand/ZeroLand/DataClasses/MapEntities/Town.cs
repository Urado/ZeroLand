using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("Town")]
    class Town : GroupActors
    {
        public int Class {get;set;}
    }
}
