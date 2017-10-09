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
        private const string _format = "Town\n{0}";
        public int Class {get;set;}
        public override string ToString()
        {
            return string.Format(_format,base.ToString());
        }
    }
}
