using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(BookStore.WebApp.Startup))]
namespace BookStore.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}