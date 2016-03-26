using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocuStoreAPI.Models
{
    public class MemberDocument
    {
        // Foreign Key
        public int MemberId { get; set; }
        // Navigation Property
        public Member Member { get; set; }

        // Foreign Key
        public int DocumentId { get; set; }
        // Navigation Property
        public Document Document { get; set; }

    }
}