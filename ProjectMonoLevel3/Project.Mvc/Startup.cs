using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project.Mvc.Startup))]
namespace Project.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
