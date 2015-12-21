using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyForum2.Startup))]
namespace MyForum2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
