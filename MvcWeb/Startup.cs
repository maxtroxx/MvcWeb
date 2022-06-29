using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWeb.Startup))]
namespace MvcWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
