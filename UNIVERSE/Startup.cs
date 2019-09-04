using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNIVERSE.Startup))]
namespace UNIVERSE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
