using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCgit.Startup))]
namespace MVCgit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
