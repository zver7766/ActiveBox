using System.Threading.Tasks;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LinksController : Controller
    {
        private readonly DataManager _manager;

        public LinksController(DataManager manager)
        {
            _manager = manager;
        }

        // GET
        public IActionResult Edit(int id)
        {
            var entity = _manager.Links.GetLinksById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Link model)
        {
            if (ModelState.IsValid)
            {
                _manager.Links.SaveLink(model);
                return RedirectToAction("Index","Home");
            }

            return View(model);
        }
    }
}