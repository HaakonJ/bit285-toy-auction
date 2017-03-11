using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyAuction.Startup))]
namespace ToyAuction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
