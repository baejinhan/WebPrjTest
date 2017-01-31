using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPrjTestStudy.Startup))]
namespace WebPrjTestStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
