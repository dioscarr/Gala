using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gala_MVC_Project.Startup))]
namespace Gala_MVC_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
