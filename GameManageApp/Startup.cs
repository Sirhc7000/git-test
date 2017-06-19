using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameManageApp.Startup))]
namespace GameManageApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
