using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje3.Models.Siniflar
{
    public class iletisim
    {
        [Key]
        public int  ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Sehir { get; set; }
        public string Mesaj { get; set; }
    }
}