using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookClone.Startup))]
namespace FacebookClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
