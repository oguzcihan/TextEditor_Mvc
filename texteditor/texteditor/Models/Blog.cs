using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace texteditor.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        [AllowHtml]
        public string icerik { get; set; }
    }
}