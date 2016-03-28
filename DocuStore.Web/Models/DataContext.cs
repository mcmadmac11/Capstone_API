using DocuStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DocuStore.Web.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<File> Files { get; set; }     
    }
  
}