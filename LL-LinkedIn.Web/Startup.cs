using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LL_LinkedIn.Web.Startup))]
namespace LL_LinkedIn.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
