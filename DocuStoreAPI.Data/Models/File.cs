﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DocuStoreAPI.Data
{
    public class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }

        [DisplayName("Date Added")]  // Reference to formatting below
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateAdded { get; set; }
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}