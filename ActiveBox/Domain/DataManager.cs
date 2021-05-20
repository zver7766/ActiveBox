using ActiveBox.Domain.Repositories.Abstract;

namespace ActiveBox.Domain
{
    public class DataManager
    {
        public IEntityBaseRepository EntityBases { get; set; }
        public ILinksRepository Links { get; set; }
        public IOurTeamRepository OurTeams { get; set; }
        public  ITypesRepository Types { get; set; }

        public DataManager(IEntityBaseRepository entityBases, ILinksRepository links, IOurTeamRepository ourTeams, ITypesRepository types)
        {
            EntityBases = entityBases;
            Links = links;
            OurTeams = ourTeams;
            Types = types;
        }
    }
}