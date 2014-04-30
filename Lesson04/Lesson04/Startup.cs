using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson04.Startup))]
namespace Lesson04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
