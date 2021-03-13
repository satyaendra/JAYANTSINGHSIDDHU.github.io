using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personal_Blog.Startup))]
namespace Personal_Blog
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
