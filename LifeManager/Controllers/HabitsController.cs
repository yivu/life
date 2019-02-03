using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeManager.Controllers
{
    public class HabitsController : Controller
    {
        // GET: TrackingTable
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrackingTable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrackingTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrackingTable/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackingTable/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrackingTable/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackingTable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrackingTable/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}