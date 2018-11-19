using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySql_Authentication.Startup))]
namespace MySql_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
