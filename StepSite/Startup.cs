using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StepSite.Startup))]
namespace StepSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
