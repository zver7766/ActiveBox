using System.Threading.Tasks;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TypesController : Controller
    {
        private readonly DataManager _manager;

        public TypesController(DataManager manager)
        {
            _manager = manager;
        }

        // GET
        public IActionResult Edit(int id)
        {
            var entity = _manager.Types.GetTypeById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Task<Type> model)
        {
            if (ModelState.IsValid)
            {
                _manager.Types.SaveType(model.Result);
                return RedirectToAction("Index","Home");
            }

            return View(model);
        }
    }
}