using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoWiki.Startup))]
namespace AutoWiki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
