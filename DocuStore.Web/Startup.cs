using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocuStore.Web.Startup))]
namespace DocuStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
