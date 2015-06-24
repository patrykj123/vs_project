using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PierwszaStronaMVC.Startup))]
namespace PierwszaStronaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
