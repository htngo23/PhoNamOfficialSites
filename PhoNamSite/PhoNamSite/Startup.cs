using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoNamSite.Startup))]
namespace PhoNamSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
