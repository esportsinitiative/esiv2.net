using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(esiv2.net.Startup))]
namespace esiv2.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
