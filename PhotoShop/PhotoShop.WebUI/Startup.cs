using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoShop.WebUI.Startup))]
namespace PhotoShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
