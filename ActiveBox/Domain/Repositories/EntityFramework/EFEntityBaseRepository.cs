using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;
using ActiveBox.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ActiveBox.Domain.Repositories.EntityFramework
{
    public class EFEntityBaseRepository : IEntityBaseRepository
    {
        private readonly AppDbContext _context;

        public EFEntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<EntityBase> GetEntityBaseItems()
        {
            return _context.Contents;
        }

        public async Task<EntityBase> GetEntityBaseItemById(int id)
        {
            return await _context.Contents.FirstOrDefaultAsync(x => x.Id == id);
        }

        public  IQueryable<EntityBase> GetEntityBaseRange(int startId, int endId)
        {
            return  _context.Contents.Where(x => x.Id >= startId && x.Id <= endId);
        }

        public async void SaveEntityBaseItem(EntityBase entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void DeleteEntityBaseItem(int id)
        {
            _context.Contents.Remove(new EntityBase() {Id = id});
            await _context.SaveChangesAsync();
        }
    }
}