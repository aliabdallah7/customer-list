using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(customer_list.Startup))]
namespace customer_list
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
