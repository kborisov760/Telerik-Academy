using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.WebForms.Application.Startup))]
namespace _01.WebForms.Application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
