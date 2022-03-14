using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(partial.Startup))]
namespace partial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
