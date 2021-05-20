using System.Threading.Tasks;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EntityBaseController : Controller
    {
        private readonly DataManager _manager;

        public EntityBaseController(DataManager manager)
        {
            _manager = manager;
        }

        // GET
        public IActionResult Edit(int id)
        {
            var entity = _manager.EntityBases.GetEntityBaseItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Task<EntityBase> model)
        {
            if (ModelState.IsValid)
            {
                _manager.EntityBases.SaveEntityBaseItem(model.Result);
                return RedirectToAction("Index","Home");
            }

            return View(model);
        }

    }
}