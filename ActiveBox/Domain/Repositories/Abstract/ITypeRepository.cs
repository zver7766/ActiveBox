using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain.Entities;

namespace ActiveBox.Domain.Repositories.Abstract
{
    public interface ITypesRepository
    {
        IQueryable<Type> GetTypes();
        Task<Type> GetTypeById(int id);
        void SaveType(Type type);
        void DeleteTypeById(int id);   
    }
}