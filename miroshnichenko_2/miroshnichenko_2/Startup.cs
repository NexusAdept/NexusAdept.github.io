using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(miroshnichenko_2.Startup))]
namespace miroshnichenko_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
