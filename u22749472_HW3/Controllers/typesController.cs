using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u22749472_HW3.Models;

namespace u22749472_HW3.Controllers
{
    //public class typesController : Controller
    //{
        //private LibraryEntities1 db = new LibraryEntities1();

        //// GET: types
        //public async Task<ActionResult> Index()
        //{
        //    return View(await db.types.ToListAsync());
        //}

        //// GET: types/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    type type = await db.types.FindAsync(id);
        //    if (type == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(type);
        //}

        //// GET: types/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: types/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "typeId,name")] type type)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.types.Add(type);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(type);
        //}

        //// GET: types/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    type type = await db.types.FindAsync(id);
        //    if (type == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(type);
        //}

        //// POST: types/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "typeId,name")] type type)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(type).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(type);
        //}

        //// GET: types/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    type type = await db.types.FindAsync(id);
        //    if (type == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(type);
        //}

        //// POST: types/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    type type = await db.types.FindAsync(id);
        //    db.types.Remove(type);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
   // }
}
