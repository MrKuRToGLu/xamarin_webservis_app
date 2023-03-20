using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { Adi = "Burak", SoyAdi = "Öz" });
            ogrencis.Add(new Ogrenci { Adi = "Ali", SoyAdi = "Yılmaz" });
            ogrencis.Add(new Ogrenci { Adi = "Cemre", SoyAdi = "Aztekin" });
            ogrencis.Add(new Ogrenci { Adi = "Ebubekir", SoyAdi = "Seyyarer" });
            ogrencis.Add(new Ogrenci { Adi = "Gökhan", SoyAdi = "Çalışkan" });
            ogrencis.Add(new Ogrenci { Adi = "Havva", SoyAdi = "Yiğit" });
            ogrencis.Add(new Ogrenci { Adi = "İsmail", SoyAdi = "Kurtoğlu" });
            ogrencis.Add(new Ogrenci { Adi = "Merve", SoyAdi = "Kazdal" });
            ogrencis.Add(new Ogrenci { Adi = "Ramazan", SoyAdi = "Yamaç" });

            return Ok(ogrencis);
        }
    }

    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}
