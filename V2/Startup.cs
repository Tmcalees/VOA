using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VOA.Startup))]
namespace VOA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
