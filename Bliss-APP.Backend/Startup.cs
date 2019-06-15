using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bliss_APP.Backend.Startup))]
namespace Bliss_APP.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
