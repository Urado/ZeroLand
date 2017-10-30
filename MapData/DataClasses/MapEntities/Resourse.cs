using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroLand.DataClasses.MapEntities
{
    public enum ResourseTypes
    {
        Gold=1,
        Iron=2,
        Food=3
    }
    public class Resourse
    {
        public int ResourseId { get; set; }
        public ResourseTypes ResourseType { get; set; }
    }
}
