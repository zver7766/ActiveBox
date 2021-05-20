using System.Linq;
using ActiveBox.Domain.Entities;

namespace ActiveBox.Areas.Admin.Models
{
    public class Entities
    {
        public IQueryable<EntityBase> Entites { get; set; }
        public IQueryable<Link> Links { get; set; }
        public IQueryable<OurTeam> Teams { get; set; }
        public IQueryable<Type> Types { get; set; }
        
    }
}