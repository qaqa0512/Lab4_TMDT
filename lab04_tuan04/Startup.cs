using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab04_tuan04.Startup))]
namespace lab04_tuan04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
