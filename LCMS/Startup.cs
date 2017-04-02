using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LCMS.Startup))]
namespace LCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
