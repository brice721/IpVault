using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onceAGAIN.Startup))]
namespace onceAGAIN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
