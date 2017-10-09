using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table("Mine")]
    public class Mine :BaseMapEnitity
    {
        private const string _format = "Mine\n{0}";
        public ResourseTypes MiningResourse { get; set; }
        public override string ToString()
        {
            return string.Format(_format, base.ToString());
        }
    }
}
