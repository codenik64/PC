using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopsConfectionary14.Startup))]
namespace PopsConfectionary14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
