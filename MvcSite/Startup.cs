using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSite.Startup))]
namespace MvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
