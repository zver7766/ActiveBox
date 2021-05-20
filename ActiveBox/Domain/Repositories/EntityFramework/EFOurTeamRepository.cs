using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;
using ActiveBox.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ActiveBox.Domain.Repositories.EntityFramework
{
    public class EFOurTeamRepository : IOurTeamRepository
    {
        private readonly AppDbContext _context;

        public EFOurTeamRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<OurTeam> GetOurTeams()
        {
            return _context.OurTeams;
        }

        public async Task<OurTeam> GetOurTeamsById(int id)
        {
            return await _context.OurTeams.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async void SaveOurTeam(OurTeam team)
        {
            _context.Entry(team).State = team.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void DeleteOurTeamById(int id)
        {
            _context.OurTeams.Remove(new OurTeam() {Id = id});
            await _context.SaveChangesAsync();
        }
    }
}