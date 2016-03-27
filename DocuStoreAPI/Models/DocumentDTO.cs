using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocuStoreAPI.Models
{
    public class DocumentDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileMime { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Document> Documents { get; set; }

    }
}

// Data Transfer Objects to Decouple service layer from database layer