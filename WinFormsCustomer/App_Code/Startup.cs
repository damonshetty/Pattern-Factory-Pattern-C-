using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinFormsCustomer.Startup))]
namespace WinFormsCustomer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
