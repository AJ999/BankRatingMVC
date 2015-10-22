using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankRateMVC.Startup))]
namespace BankRateMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
