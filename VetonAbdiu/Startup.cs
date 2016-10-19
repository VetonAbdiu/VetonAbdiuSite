using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VetonAbdiu.Startup))]
namespace VetonAbdiu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
