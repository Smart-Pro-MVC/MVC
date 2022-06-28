using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Template.Listeler
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyatı { get; set; }
        public bool StoktaVar { get; set; }
    }
}