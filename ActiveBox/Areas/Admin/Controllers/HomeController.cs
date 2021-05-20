using System.Linq;
using ActiveBox.Areas.Admin.Models;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager _manager;

        public HomeController(DataManager manager)
        {
            _manager = manager;
        }

        // GET
        public IActionResult Index()
        {
            Entities e = new Entities()
            {
                Entites = _manager.EntityBases.GetEntityBaseItems().Where(x=> x.TypeId != 1005 && x.TypeId != 1002 && x.TypeId != 1007),
                Links = _manager.Links.GetLinks(),
                Teams = _manager.OurTeams.GetOurTeams(),
                Types = _manager.Types.GetTypes()
            };
            return View(e);
        }
    }
}