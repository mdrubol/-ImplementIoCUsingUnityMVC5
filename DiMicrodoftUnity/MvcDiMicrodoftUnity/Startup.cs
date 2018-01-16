using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDiMicrodoftUnity.Startup))]
namespace MvcDiMicrodoftUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Bootstrapper.Initialise();
        }
    }
}
