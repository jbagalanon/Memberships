using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Memmberships.Startup))]
namespace Memmberships
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
