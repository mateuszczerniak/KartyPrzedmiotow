using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KartyPrzedmiotow2.Startup))]
namespace KartyPrzedmiotow2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
