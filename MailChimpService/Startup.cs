using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MailChimpService.Startup))]
namespace MailChimpService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
