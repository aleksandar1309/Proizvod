using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZadatakProizvod.Models;

namespace ZadatakProizvod.Controllers
{
    public class ProizvodJsonController : Controller
    {
       // private readonly String path 

        public IActionResult Index()
        {
            var webClient = new WebClient();
           

            var json = webClient.DownloadString(@"/Users/Aleksandar/source/repos/ZadatakProizvod/ZadatakProizvod/wwwroot/Proizvodi.json");
            var proizvodi = JsonConvert.DeserializeObject<List<ProizvodJson>>(json);

            return View(proizvodi);
        }

        public IActionResult Write()
        {

            string path = $"C:\\Users\\Aleksandar\\source\\repos\\ZadatakProizvod\\ZadatakProizvod\\wwwroot\\Proizvodi.json";

            Proizvod proizvod = new Proizvod();
            proizvod.Id = 1;
            proizvod.Naziv = "Cokolada";
            proizvod.Opis = "Mlecna cokolada";
            proizvod.Kategorija = "Slatkisi";
            proizvod.Dobavljac = "Maxi";
            proizvod.Cena = 100;
            
            string json = JsonConvert.SerializeObject(proizvod);
            return View();
        }

        public IActionResult Read()
        {
            string path = $"C:\\Users\\Aleksandar\\source\\repos\\ZadatakProizvod\\ZadatakProizvod\\wwwroot\\Proizvodi.json";

       
            WebClient wc = new WebClient();
            var json = wc.DownloadString("path");
            Proizvod pr = JsonConvert.DeserializeObject<Proizvod>(json);

            

            return View();
        }

       

      
    }
}