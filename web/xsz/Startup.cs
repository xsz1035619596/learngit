using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xsz.Startup))]
namespace xsz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
