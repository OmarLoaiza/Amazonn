using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amazonn.Startup))]
namespace Amazonn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
