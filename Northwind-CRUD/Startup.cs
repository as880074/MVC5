using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwind_CRUD.Startup))]
namespace Northwind_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
