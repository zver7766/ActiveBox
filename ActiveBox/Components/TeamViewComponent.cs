using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public TeamViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teams = _manager.OurTeams.GetOurTeams();
            return View(teams.Where(x=> x.TypeId == 1005));
        }
    }
}