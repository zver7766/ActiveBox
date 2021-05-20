using System.Threading.Tasks;
using ActiveBox.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Components
{
    public class FeaturesViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public FeaturesViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_manager.EntityBases.GetEntityBaseRange(1005,1010));
        }
    }
}