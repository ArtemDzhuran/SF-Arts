using Microsoft.Owin;
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
