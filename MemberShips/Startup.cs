using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberShips.Startup))]
namespace MemberShips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
