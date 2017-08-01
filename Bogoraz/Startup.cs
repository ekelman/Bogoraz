using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bogoraz.Startup))]
namespace Bogoraz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
