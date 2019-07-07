using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Invetario.Models;

namespace Invetario.Controllers
{
    public class TipoInventariosController : Controller
    {
        private InventarioContext db = new InventarioContext();

        // GET: TipoInventarios
        public ActionResult Index()
        {
            return View(db.Tipo_Inventario.ToList());
        }

        // GET: TipoInventarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoInventario tipoInventario = db.Tipo_Inventario.Find(id);
            if (tipoInventario == null)
            {
                return HttpNotFound();
            }
            return View(tipoInventario);
        }

        // GET: TipoInventarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoInventarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tipo_inventario,descripcion_tipo,cuenta_contable,estado")] TipoInventario tipoInventario)
        {
            if (ModelState.IsValid)
            {
                db.Tipo_Inventario.Add(tipoInventario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoInventario);
        }

        // GET: TipoInventarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoInventario tipoInventario = db.Tipo_Inventario.Find(id);
            if (tipoInventario == null)
            {
                return HttpNotFound();
            }
            return View(tipoInventario);
        }

        // POST: TipoInventarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tipo_inventario,descripcion_tipo,cuenta_contable,estado")] TipoInventario tipoInventario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoInventario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoInventario);
        }

        // GET: TipoInventarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoInventario tipoInventario = db.Tipo_Inventario.Find(id);
            if (tipoInventario == null)
            {
                return HttpNotFound();
            }
            return View(tipoInventario);
        }

        // POST: TipoInventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoInventario tipoInventario = db.Tipo_Inventario.Find(id);
            db.Tipo_Inventario.Remove(tipoInventario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
