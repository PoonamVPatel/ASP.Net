using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team9_Books_Online.Startup))]
namespace Team9_Books_Online
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
