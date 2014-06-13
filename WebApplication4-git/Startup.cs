using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication4_git.Startup))]
namespace WebApplication4_git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
