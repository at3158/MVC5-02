using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_02.Startup))]
namespace MVC5_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
