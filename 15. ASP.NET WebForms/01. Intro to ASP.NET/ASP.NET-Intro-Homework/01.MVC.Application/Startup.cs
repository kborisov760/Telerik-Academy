using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.MVC.Application.Startup))]
namespace _01.MVC.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
