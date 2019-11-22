using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;

        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            var superheroFolk = context.Superheroes.ToList();
            return View(superheroFolk);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Superhero foundHero = context.Superheroes.Where(i => i.id == id).FirstOrDefault();
            return View(foundHero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View();
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superheroFromDb = context.Superheroes.Where(i => i.id == id).FirstOrDefault();
            return View();
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero superheroFromDb = context.Superheroes.Where(i => i.id == id).FirstOrDefault();
                if (superhero.superName != null)
                {
                    superheroFromDb.superName = superhero.superName;
                }
                else
                {
                    superheroFromDb.superName = superheroFromDb.superName;
                }
                if (superhero.alterEgoName != null)
                {
                    superheroFromDb.alterEgoName = superhero.alterEgoName;
                }
                else
                {
                    superheroFromDb.alterEgoName = superheroFromDb.alterEgoName;
                }
                if (superhero.primarySuperpower != null)
                {
                    superheroFromDb.primarySuperpower = superhero.primarySuperpower;
                }
                else
                {
                    superheroFromDb.primarySuperpower = superheroFromDb.primarySuperpower;
                }
                if (superhero.secondarySuperpower != null)
                {
                    superheroFromDb.secondarySuperpower = superhero.secondarySuperpower;
                }
                else
                {
                    superheroFromDb.secondarySuperpower = superheroFromDb.secondarySuperpower;
                }
                if (superhero.catchphrase != null)
                {
                    superheroFromDb.catchphrase = superhero.catchphrase;
                }
                else
                {
                    superheroFromDb.catchphrase = superheroFromDb.catchphrase;
                }

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                superhero = context.Superheroes.Where(s => s.id == id).FirstOrDefault();
                context.Superheroes.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
