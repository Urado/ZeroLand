using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using ZeroLand.Logic.MapEnitityVisitor;

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

        public override void Visit(IMapEnitityVisitor visitor, ICollection<BaseMapEnitity> detected)
        {
            visitor.VisitGroupActors(this, detected);
            base.Visit(visitor, detected);
        }

        ///*
        private const string _format = "{0}Actors:\n{1}Resourses:\n{2}";
        public override string ToString()
        {
            string actorsString = "";
            string resoursesString = "";
            /*
            foreach (var a in Actors)
                actorsString += a.ToString() + "\n";
  
            foreach (var a in Resourses)
                resoursesString += a.ToString() + "\n";*/
            return string.Format(_format, base.ToString(), actorsString, resoursesString);
        }
        //*/
    }
}
