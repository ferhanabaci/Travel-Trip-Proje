﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje3.Models.Siniflar;

namespace TravelTripProje3.Controllers
{
    public class GirişYapController : Controller
    {
        // GET: GirişYap
        Context c = new Context();
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost] // veri gönderme işlemi oldugu zaman 
        public ActionResult Login(Admin ad )
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.Kullanici==ad.Kullanici && x.Sifre==ad.Sifre);// kullanıcı adı veya sıfresı dogru mu
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici,false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirişYap");
        }
    }
}