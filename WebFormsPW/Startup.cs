using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsPW.Startup))]
namespace WebFormsPW
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
