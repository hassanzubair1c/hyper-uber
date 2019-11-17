using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hyper_Uber.Startup))]
namespace Hyper_Uber
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
