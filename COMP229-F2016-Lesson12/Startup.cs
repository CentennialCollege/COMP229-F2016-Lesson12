using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_F2016_Lesson12.Startup))]
namespace COMP229_F2016_Lesson12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
