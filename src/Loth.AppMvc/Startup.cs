using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loth.AppMvc.Startup))]
namespace Loth.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
