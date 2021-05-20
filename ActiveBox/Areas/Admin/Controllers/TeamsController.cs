using System.Threading.Tasks;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamsController : Controller
    {
        private readonly DataManager _manager;

        public TeamsController(DataManager manager)
        {
            _manager = manager;
        }

        // GET
        public IActionResult Edit(int id)
        {
            var entity = _manager.OurTeams.GetOurTeamsById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Task<OurTeam> model)
        {
            if (ModelState.IsValid)
            {
                _manager.OurTeams.SaveOurTeam(model.Result);
                return RedirectToAction("Index","Home");
            }
            return View(model);
        }
    }
}