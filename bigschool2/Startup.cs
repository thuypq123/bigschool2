using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigschool2.Startup))]
namespace bigschool2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
