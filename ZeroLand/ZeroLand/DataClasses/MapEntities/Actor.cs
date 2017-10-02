using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroLand.DataClasses.MapEntities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public int KeeperId { get; set; }
        public Keeper ActorKeeper { get; set; }
    }
}
