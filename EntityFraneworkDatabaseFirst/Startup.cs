using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFraneworkDatabaseFirst.Startup))]
namespace EntityFraneworkDatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
