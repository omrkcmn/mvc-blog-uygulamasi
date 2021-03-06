﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlogProjesi.Models;

namespace MvcBlogProjesi.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext bc = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = bc.Bloglar
                .Select(i=>new BlogModel()
                {
                    Id = i.Id,
                    Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0,100)+"..." : i.Baslik,
                    Aciklama = i.Aciklama,
                    EklenmeTarihi = i.EklenmeTarihi,
                    Anasayfa = i.Anasayfa,
                    Onay = i.Onay,
                    Resim = i.Resim
                })
                .Where(i => i.Onay == true && i.Anasayfa == true).OrderByDescending(i=>i.EklenmeTarihi);
            
            return View(bloglar.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}