using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DocuStoreAPI.Data;

namespace DocuStoreAPI.Models
{
    public class DocuStoreDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DocuStoreDBContext() : base("name=DocuStoreDBContext")
        {
            
        }

        
        public System.Data.Entity.DbSet<DocuStoreAPI.Models.Document> Documents { get; set; }

        public System.Data.Entity.DbSet<DocuStoreAPI.Data.Member> Members { get; set; }
        public DbSet<DocuStoreAPI.Data.File> Files { get; set; }
    }
}
