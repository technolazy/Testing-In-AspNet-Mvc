using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson01.Startup))]
namespace Lesson01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
