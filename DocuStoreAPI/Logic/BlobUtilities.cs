using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;

namespace DocuStoreAPI.Logic
{
    public class BlobUtilities
    {
        public static CloudBlobClient GetBlobClient
        {
            get
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=http;AccountName=docstationstorage;AccountKey=avlXJZ39xiCk3IM9jwbh0SMHWiY1CJcQpTSCi//fp4oP5aMu6j3qmB9QP4C34zBtmzBdIyLGJ7wJ5FTslf5KqA== ;");
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                return blobClient;
            }
        }
    }
}