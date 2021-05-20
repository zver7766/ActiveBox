using System.Threading.Tasks;
using ActiveBox.Domain;
using ActiveBox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ActiveBox.Components
{
    public class IntroViewComponent : ViewComponent
    {
        private readonly DataManager _manager;

        public IntroViewComponent(DataManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //_manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "Your Favorite One Page Multi Purpose Template",Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent commodo cursus magna vel scelerisque nisl consectetur et.",Position = "Find out more",TypeId = 1002});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Easily Customised",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Responsive REady",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Modern Design",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Clean Code",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Ready to Ship",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Download for Free",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis risus eget urna mollis ornare vel eu leo. Donec ullamcorper nulla",TypeId = 1003 });
            //
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Project Name",Text = "User Interface Design",TypeId = 1004});
            //
            // _manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "Ruth Woods",Text = "Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.", Position = "Founder, CEO",TypeId = 1005});
            // _manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "Timothy Reed",Text = "Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.", Position = "Co-Founder, Developer",TypeId = 1005});
            // _manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "Victoria Valdez",Text = "Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.", Position = "UI Designer",TypeId = 1005});
            // _manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "Beverly Little",Text = "Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.", Position = "Data Scientist",TypeId = 1005});
            //
            //  //links
            //
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Susan Sims, AT XYZ",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis",TypeId = 1006});
            // _manager.EntityBases.SaveEntityBaseItem(new EntityBase(){Header = "Susan Sims, AT XYZ",Text = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Nullam quis",TypeId = 1006});
            //
            //  _manager.OurTeams.SaveOurTeam(new OurTeam(){Header = "FUSCE DAPIDUS, TELL US AC",Text = "Are You Ready to Start? Download Now For Free!",Position = "Download here",TypeId = 1007});

            return View(_manager.OurTeams.GetOurTeamsById(1002));
        }
    }
}