using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;

namespace ActiveBox.Domain.Repositories.Abstract
{
    public interface IOurTeamRepository
    {
        IQueryable<OurTeam> GetOurTeams();
        Task<OurTeam> GetOurTeamsById(int id);
        void SaveOurTeam(OurTeam team);
        void DeleteOurTeamById(int id);
    }
}