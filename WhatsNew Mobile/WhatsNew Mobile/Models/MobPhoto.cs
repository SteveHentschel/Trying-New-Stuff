using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatsNew_Mobile.Models
{
    public class MobPhoto
    {
        public string Title { get; set; }

        public string FileName { get; set; }

        public string Description { get; set; }

        public DateTime UploadDate { get; set; }
    }
}