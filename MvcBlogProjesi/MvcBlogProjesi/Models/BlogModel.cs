using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }
        public string Resim { get; set; }
    }
}