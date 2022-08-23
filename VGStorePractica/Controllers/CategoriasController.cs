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

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categorias.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categorias obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categorias.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categorias.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? IdCategoria)
        {
            var obj = _db.Categorias.Find(IdCategoria);
            _db.Categorias.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
