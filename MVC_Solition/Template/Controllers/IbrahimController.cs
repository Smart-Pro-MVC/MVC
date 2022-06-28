using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Listeler;

namespace Template.Controllers
{
    public class IbrahimController : Controller
    {
        // GET: Ibrahim
        public ActionResult Ibrahim()
        {
            List<Urun> UrunListesi = new List<Urun>();
            Urun Liste = new Urun();
            Liste.Id = 1;
            Liste.UrunAdi = "Samsung s7";
            Liste.Fiyatı = 5000;
            Liste.StoktaVar = true;
            UrunListesi.Add(Liste);
            
            Liste.Id = 2;
            Liste.UrunAdi = "Samsung s10";
            Liste.Fiyatı = 6000;
            Liste.StoktaVar = true;
            UrunListesi.Add(Liste);

            Liste.Id = 3;
            Liste.UrunAdi = "Samsung s11";
            Liste.Fiyatı = 7000;
            Liste.StoktaVar = false;
            UrunListesi.Add(Liste);


            return View(UrunListesi.ToList());

 
        }
        public ActionResult Ibrahim2()
        {
           
            string[] Kategoriler = { "Bilgisayar", "Telefon", "Aksesuar", "Beyaz Eşya", "Ev Elektroniği","Ses Sistemi" };
            return View(Kategoriler);
        }
    }
}