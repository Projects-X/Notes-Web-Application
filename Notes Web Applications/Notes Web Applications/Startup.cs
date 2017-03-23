using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notes_Web_Applications.Startup))]
namespace Notes_Web_Applications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
