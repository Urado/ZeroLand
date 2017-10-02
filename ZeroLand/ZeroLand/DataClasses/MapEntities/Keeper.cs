using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroLand.DataClasses.MapEntities
{
    public class Keeper
    {
        public int KeeperId { get; set; }
        public string Name { get; set; } 
        public ICollection<BaseMapEnitity> KeptEnitity { get; set; }
        public ICollection<Actor> KeptActors { get; set; }
        public Keeper()
        {
            KeptEnitity = new HashSet<BaseMapEnitity>();
            KeptActors = new HashSet<Actor>();
        }
    }
}
