namespace DocuStoreAPI.Migrations
{
    using DocuStoreAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DocuStoreAPI.Models.DocuStoreAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DocuStoreAPI.Models.DocuStoreAPIContext context)
        {
            context.Members.AddOrUpdate(x => x.Id,
                new Member() { Id=1, FirstName = "Dan",LastName="McManus",Email="danmcmanus11@outlook.com" },
                new Member() { Id=2,FirstName="Sara",LastName="Kimball",Email="mcmanus.dbm@gmail.com" }
                );
            
            context.Documents.AddOrUpdate(x => x.Id,
                new Document() {Id=1,DocumentName="Will" },
                new Document() {Id=2,DocumentName="Life Insurance Policy" },
                new Document() {Id=3,DocumentName="Power of Attorney" },
                new Document() {Id=4,DocumentName="Advanced Directive/Living Will" }
                );
        }
    }
}
