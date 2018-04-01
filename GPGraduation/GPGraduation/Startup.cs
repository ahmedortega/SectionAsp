using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPGraduation.Startup))]
namespace GPGraduation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
