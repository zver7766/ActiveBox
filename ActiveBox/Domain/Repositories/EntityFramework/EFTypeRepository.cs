using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;
using ActiveBox.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ActiveBox.Domain.Repositories.EntityFramework
{
    public class EFTypeRepository : ITypesRepository
    {
        private readonly AppDbContext _context;

        public EFTypeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Type> GetTypes()
        {
            return _context.Types;
        }

        public async Task<Type> GetTypeById(int id)
        {
            return await _context.Types.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async void SaveType(Type type)
        {
            _context.Entry(type).State = type.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void DeleteTypeById(int id)
        {
            _context.Types.Remove(new Type() {Id = id});
            await _context.SaveChangesAsync();
        }
    }
}