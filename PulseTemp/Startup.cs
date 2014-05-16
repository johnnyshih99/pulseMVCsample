using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PulseTemp.Startup))]
namespace PulseTemp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
