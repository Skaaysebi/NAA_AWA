using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAA.Webapplication.Startup))]
namespace NAA.Webapplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
