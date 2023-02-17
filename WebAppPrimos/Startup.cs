using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPrimos.Startup))]
namespace WebAppPrimos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
