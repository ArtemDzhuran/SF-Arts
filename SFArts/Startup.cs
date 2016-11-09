using Microsoft.Owin;
using NLog;
using NLog.Config;
using NLog.Targets;
using Owin;

[assembly: OwinStartupAttribute(typeof(SFArts.Startup))]
namespace SFArts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
