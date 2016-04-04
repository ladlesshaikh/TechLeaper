using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TL.Web.UI.Startup))]
namespace TL.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
