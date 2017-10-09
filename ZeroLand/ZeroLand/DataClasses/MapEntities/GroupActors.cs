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
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Resourse> Resourses { get; set; }

        public GroupActors()
        {
            Actors = new HashSet<Actor>();
            Resourses = new HashSet<Resourse>();
        }
        ///*
        private const string _format = "{0}Actors:\n{1}Resourses:\n{2}";
        public override string ToString()
        {
            string actorsString = "";
            foreach (var a in Actors)
                actorsString += a.ToString() + "\n";
            string resoursesString = "";
            foreach (var a in Resourses)
                resoursesString += a.ToString() + "\n";
            return string.Format(_format, base.ToString(), actorsString, resoursesString);
        }
        //*/
    }
}
