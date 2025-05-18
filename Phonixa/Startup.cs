using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phonixa.Startup))]
namespace Phonixa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
