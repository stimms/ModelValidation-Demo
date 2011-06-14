using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication7.Models;
using System.Threading;

namespace MvcApplication7.Controllers
{   
    public class AssassinsController : Controller
    {
        private MvcApplication7Context context = new MvcApplication7Context();

        //
        // GET: /Assassins/

        public ViewResult Index()
        {
            return View(context.Assassins.ToList());
        }

        //
        // GET: /Assassins/Details/5

        public ViewResult Details(int id)
        {
            Assassin assassin = context.Assassins.Single(x => x.ID == id);
            return View(assassin);
        }

        //
        // GET: /Assassins/Create

        public ActionResult Create()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            return View();
        } 

        //
        // POST: /Assassins/Create

        [HttpPost]
        public ActionResult Create(Assassin assassin)
        {
            if (ModelState.IsValid)
            {
                context.Assassins.Add(assassin);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(assassin);
        }
        
        //
        // GET: /Assassins/Edit/5
 
        public ActionResult Edit(int id)
        {
            Assassin assassin = context.Assassins.Single(x => x.ID == id);
            return View(assassin);
        }

        //
        // POST: /Assassins/Edit/5

        [HttpPost]
        public ActionResult Edit(Assassin assassin)
        {
            if (ModelState.IsValid)
            {
                context.Entry(assassin).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assassin);
        }

        //
        // GET: /Assassins/Delete/5
 
        public ActionResult Delete(int id)
        {
            Assassin assassin = context.Assassins.Single(x => x.ID == id);
            return View(assassin);
        }

        //
        // POST: /Assassins/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Assassin assassin = context.Assassins.Single(x => x.ID == id);
            context.Assassins.Remove(assassin);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}