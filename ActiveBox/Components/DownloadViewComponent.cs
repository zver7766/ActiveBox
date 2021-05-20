using System.Threading.Tasks;
using ActiveBox.Domain;
using Microsoft.AspNetCore.Mvc;
// ReSharper disable Mvc.ViewComponentViewNotResolved

namespace ActiveBox.Components
{
    public class DownloadViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public DownloadViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_manager.OurTeams.GetOurTeamsById(1029));
        }
    }
}