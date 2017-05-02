using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Socialite.Startup))]
namespace Socialite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
