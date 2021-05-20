using System.Collections.Generic;
using System.Linq;
using ActiveBox.Domain.Entities;

namespace ActiveBox.Domain.Repositories.Abstract
{
    public interface ILinksRepository
    {
        IQueryable<Link> GetLinks();
        IQueryable<Link> GetLinksByContentId(int id);
        Link GetLinksById(int id);
        void SaveLink(Link link);
        void DeleteLinkById(int id);
        void DeleteLinkByContentId(int id); 
    }
}