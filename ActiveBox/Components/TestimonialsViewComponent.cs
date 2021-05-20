using System.Linq;
using System.Threading.Tasks;
using ActiveBox.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ActiveBox.Components
{
    public class TestimonialsViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public TestimonialsViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View( _manager.EntityBases.GetEntityBaseItems().Where(x=> x.TypeId == 1006));
        }
    }
}