using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleAPIConsumption.Startup))]
namespace GoogleAPIConsumption
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
