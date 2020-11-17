using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZadatakProizvod.Data;
using ZadatakProizvod.Models;
using Microsoft.EntityFrameworkCore;

namespace ZadatakProizvod.Controllers
{
    public class ProizvodController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProizvodController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Proizvodi.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Naziv,Opis,Kategorija,Proizvodjac,Dobavljac,Cena")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Proizvodi.Add(proizvod);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    ViewBag.Greska = "Greska pri unosu proizvoda";
                    return View(proizvod);
                }
            }

            return View(proizvod);
        }


        // GET: Proizvods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvod = await db.Proizvodi.FindAsync(id);
            if (proizvod == null)
            {
                return NotFound();
            }
            return View(proizvod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Naziv,Opis,Kategorija,Proizvodjac,Dobavljac,Cena")] Proizvod proizvod)
        {
            if (id != proizvod.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(proizvod);
                   // db.Entry(proizvod).State = EntityState.Modified;
                    db.SaveChanges();
                } 
                catch (Exception)
                {
                    db.Entry(proizvod).State = EntityState.Unchanged;
                    ViewBag.Greska = "Greska prilikom unosa proizvoda";
                    return View(proizvod);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(proizvod);
        }
    }
}