using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;

namespace ActiveBox.Domain.Repositories.Abstract
{
    public interface IEntityBaseRepository
    {
        IQueryable<EntityBase> GetEntityBaseItems();
        Task<EntityBase> GetEntityBaseItemById(int id);
        IQueryable<EntityBase> GetEntityBaseRange(int startId, int endId);
        void SaveEntityBaseItem(EntityBase entity);
        void DeleteEntityBaseItem(int id);
    }
}