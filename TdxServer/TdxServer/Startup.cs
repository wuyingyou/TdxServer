using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TdxServer.Startup))]
namespace TdxServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
