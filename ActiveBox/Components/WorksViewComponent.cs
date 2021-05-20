using System.Threading.Tasks;
using ActiveBox.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Components
{
    public class WorksViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public WorksViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_manager.EntityBases.GetEntityBaseRange(1011,1018));
        }
    }
}