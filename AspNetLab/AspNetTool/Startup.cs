using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetTool.Startup))]
namespace AspNetTool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
