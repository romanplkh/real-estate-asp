using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Horizon.Startup))]
namespace Horizon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
