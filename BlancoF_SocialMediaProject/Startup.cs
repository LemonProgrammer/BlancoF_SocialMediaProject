using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlancoF_SocialMediaProject.Startup))]
namespace BlancoF_SocialMediaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
