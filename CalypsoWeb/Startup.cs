using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalypsoWeb.Startup))]
namespace CalypsoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
