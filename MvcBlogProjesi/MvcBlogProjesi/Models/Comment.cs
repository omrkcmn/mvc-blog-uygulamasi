using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public string YazarAdi { get; set; }
        public string YazarResmi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        //public int CevapId { get; set; }//Cevaplanacak yorumun ID değeri.

        //Foreign Key
        public int BlogId { get; set; }
        public Blog blog { get; set; }
    }
}