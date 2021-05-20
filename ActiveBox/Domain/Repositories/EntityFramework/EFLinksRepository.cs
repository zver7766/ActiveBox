using System.Linq;
using ActiveBox.Domain.Entities;
using ActiveBox.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ActiveBox.Domain.Repositories.EntityFramework
{
    public class EFLinksRepository : ILinksRepository
    {
        private readonly AppDbContext _context;

        public EFLinksRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Link> GetLinks()
        {
            return _context.Links;
        }

        public Link GetLinksById(int id)
        {
            return _context.Links.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Link> GetLinksByContentId(int id)
        {
            return _context.Links.Where(x => x.EntityBaseId == id);
        }
        
        public async void SaveLink(Link link)
        {
            _context.Entry(link).State = link.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async void DeleteLinkById(int id)
        {
            _context.Links.Remove(new Link() {Id = id});
            await _context.SaveChangesAsync();
        }

        public async void DeleteLinkByContentId(int id)
        {
            _context.Links.Remove(new Link() {EntityBaseId = id});
            await _context.SaveChangesAsync();
        }
    }
}