using Microsoft.Owin;
using Owin;







[assembly: OwinStartupAttribute(typeof(CommanderWebsite.Startup))]
namespace CommanderWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }

    }
}
