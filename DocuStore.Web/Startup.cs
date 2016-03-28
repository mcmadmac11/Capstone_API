using Microsoft.Owin;
using Owin;
using DocuStoreAPI.Data;

[assembly: OwinStartupAttribute(typeof(DocuStore.Web.Startup))]
namespace DocuStore.Web
{
    public partial class Startup
    {
        DocuStoreAPI.Data.Models.DocuStoreDBContext dbContext = new DocuStoreAPI.Data.Models.DocuStoreDBContext();
        public void Configuration(IAppBuilder app)
        {
            
            ConfigureAuth(app);
        }
    }
}
