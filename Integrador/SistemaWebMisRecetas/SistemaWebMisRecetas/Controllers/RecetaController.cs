using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetaContext context;

        public RecetaController(DBRecetaContext context)
        {
            this.context = context;
        }
       
        public IActionResult Index()
        {
            var recetas = context.Recetas.Include(x => x.Autor).ToList();
            return View(recetas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Autor autor = new Autor();
            Receta receta = new Receta();
            receta.Autor = autor;

            return View(receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult GetByName(string nombre, string apellido)
        {
            List<Receta> recetas = (from r in context.Recetas
                                    where r.Autor.Nombre == nombre && r.Autor.Apellido == apellido
                                    select r).Include(x => x.Autor).ToList();

            return View(recetas);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = GetReceta(id);

            if (receta == null)
            {
                return NotFound();
            }
            return View(receta);
        }

        private Receta GetReceta(int id)
        {
            return context.Recetas.Include(x => x.Autor).FirstOrDefault();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = GetReceta(id);
            if (receta == null)
            {
                return NotFound();
            }

            return View(receta);
        }

        [HttpPost]
        public ActionResult Edit(int id, Receta receta)
        {
            if(id != receta.Id)
            {
                return BadRequest();
            }
            else if (ModelState.IsValid)
            {
                context.Entry(receta.Autor).State = EntityState.Modified;
                context.Entry(receta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(receta);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Receta receta = GetReceta(id);
            if (receta == null)
            {
                return NotFound();
            }
            return View(receta);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Receta receta = GetReceta(id);
            if (receta == null)
            {
                return NotFound();
            }
            context.Recetas.Remove(receta);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
