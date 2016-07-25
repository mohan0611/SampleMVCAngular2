using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleMVCAngular.Startup))]
namespace SampleMVCAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
