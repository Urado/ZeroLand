using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;

namespace ZeroLand.DataClasses
{
    class DataKeeper
    {
        public static DataKeeper Data = new DataKeeper();
        private DataKeeper() { }
        public List<BaseMapEnitity> Enitities { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
