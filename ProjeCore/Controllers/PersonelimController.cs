using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace ProjeCore.Controllers
{
    public class PersonelimController : Controller
    {

        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x => x.Birim).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAd,
                                                 Value = x.BirimID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            var per = c.Birims.Where(x => x.BirimID == p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelGetir(int id)
        {
            List<SelectListItem> values = (from y in c.Birims.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.BirimAd,
                                               Value = y.BirimID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            var depart = c.Personels.Find(id);
            return View("PersonelGetir", depart);
        }
        public IActionResult PersonelGüncelle(Personel p)
        {
            var depart = c.Personels.Find(p.PersonelID);
            depart.Ad = p.Ad;
            depart.Soyad = p.Soyad;
            depart.Sehir = p.Sehir;
            depart.BirimID = p.BirimID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
