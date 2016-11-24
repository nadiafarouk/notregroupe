using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UltimateWeb.Startup))]
namespace UltimateWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
