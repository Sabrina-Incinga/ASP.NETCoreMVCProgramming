﻿using Microsoft.AspNetCore.Mvc;
using MVCEmpleado.Data;
using MVCEmpleado.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadosContext context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Empleado> empleados = context.Empleados.ToList();
            return View(empleados);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View(empleado);
        }
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(empleado);
        }
        [HttpGet]
        public ActionResult GetByTitle(string titulo)
        {
            List<Empleado> empleados = (from e in context.Empleados
                                        where e.Titulo == titulo
                                        select e).ToList();

            if(empleados.Count == 0)
            {
                return NotFound();
            }

            return View(empleados);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if(empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            context.Empleados.Remove(empleado);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
