using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VGStorePractica.Data;
using VGStorePractica.Models;

namespace VGStorePractica.Controllers
{
    public class CategoriasController : Controller
    {
        //***************************************************
        private readonly AppDbContext _db;
        public CategoriasController(AppDbContext db)  //CTOR
        {
            _db = db;
        }
        //***************************************************
        public IActionResult Index()
        {
            IEnumerable<Categorias> objList = _db.Categorias;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categorias obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categorias.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
