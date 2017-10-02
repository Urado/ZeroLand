using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroLand.DataClasses.MapEntities
{
    public class GroupActors : BaseMapEnitity
    {
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Resourse> Resourses { get; set; }

        public GroupActors()
        {
            Actors = new HashSet<Actor>();
            Resourses = new HashSet<Resourse>();
        }
    }
}
