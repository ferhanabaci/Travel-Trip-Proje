using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTripProje3.Models.Siniflar
{
    public class BlogYorum
    {
        //blogların listelenecegi sayfa
        // hangi tablolarımdan veri cekiceksem,hangi tablolarımda ıslem gerceklestırceksem o tabloların bir ınterface formatında yazcam(belli degerleri belli bir formatta toplayan yapıdır)
        public IEnumerable<Blog> Deger1 { get; set; }  // imlece içine hangi tabloysa o ismine de deger1 yazdık 
        //yukarda bir property olusturmus oldum 
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        // IEnumerable aracıgyla bir view icerisinde  birden fazla tablodan bir fazla deger cekicem 
        
        public IEnumerable<Blog> Deger3 { get; set; }    
    }
}