using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckTokenByDefault.Startup))]
namespace CheckTokenByDefault
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
