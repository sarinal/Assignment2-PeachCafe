using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2_PeachCafe.Startup))]
namespace Assignment2_PeachCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
