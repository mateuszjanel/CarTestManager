using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarTestManager.Startup))]
namespace CarTestManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
