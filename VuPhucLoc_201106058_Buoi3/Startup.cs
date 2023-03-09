using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuPhucLoc_201106058_Buoi3.Startup))]
namespace VuPhucLoc_201106058_Buoi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
