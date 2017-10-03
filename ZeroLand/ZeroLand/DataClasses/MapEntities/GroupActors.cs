using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ZeroLand.DataClasses.MapEntities
{
    [Table(Name = "GroupActors")]
    public abstract class GroupActors : BaseMapEnitity
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
