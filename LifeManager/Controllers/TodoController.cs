using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeManager.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeManager.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public TodoController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        // GET: Todo
        public async Task<ActionResult> Index()
        {
            var todos = await dbContext.Todos.OrderBy(a => a.Id).ToListAsync();
            return View(todos);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo/Create
        
        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Todo todo)
        {
            try
            {
                await dbContext.Todos.AddAsync(todo);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = dbContext.Todos.Single(a => a.Id == id);
            return View(todo);
        }

        // POST: Todo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Todo todo)
        {
            try
            {
                dbContext.Todos.Update(todo);
                dbContext.SaveChanges();
                // TODO: Add update logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Delete/5
        public async  Task<ActionResult> Delete(int id)
        {
            dbContext.Todos.Remove(dbContext.Todos.Single(a => a.Id == id));
            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Todo/Delete/5
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