using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kateg = new List<Category>()
            {
                new Category(){KategoriAdi = "C#"},
                new Category(){KategoriAdi = "Asp .net MVC"},
                new Category(){KategoriAdi = "Java"},
                new Category(){KategoriAdi = "Python"},
            };

            foreach (var item in kateg)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog() {Baslik = "C# Delegate kullanımıC# Delegate kullanımıC# Delegate",EklenmeTarihi = DateTime.Now.AddDays(-10),Anasayfa = true,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "1.jpg",CategoryId = 1},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-30),Anasayfa = true,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "2.jpg",CategoryId = 2},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-40),Anasayfa = false,Onay=false,Icerik = "Burası içerik kısmı.", Resim = "2.jpg",CategoryId = 2},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-70),Anasayfa = true,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "2.jpg",CategoryId = 2},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-80),Anasayfa = false,Onay=false,Icerik = "Burası içerik kısmı.", Resim = "1.jpg",CategoryId = 1},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-90),Anasayfa = false,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "2.jpg",CategoryId = 4},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-200),Anasayfa = true,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "1.jpg",CategoryId = 3},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-4000),Anasayfa = true,Onay=true,Icerik = "Burası içerik kısmı.", Resim = "1.jpg",CategoryId = 4},
                new Blog() {Baslik = "C# Delegate kullanımı",EklenmeTarihi = DateTime.Now.AddDays(-10),Anasayfa = false,Onay=false,Icerik = "Burası içerik kısmı.", Resim = "2.jpg",CategoryId = 3},
            };

            foreach (var item in blogs)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}