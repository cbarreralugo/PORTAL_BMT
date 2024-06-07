using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEB_SAM_BMT.Models;

namespace WEB_SAM_BMT.Controllers
{
    public class PublicacionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Publicacion
        public ActionResult Index()
        {
            return View(db.Publicacion.ToList());
        }

        // GET: Publicacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // GET: Publicacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publicacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_publicacion,nombre_app,ruta_origen,servidor,tipo_publicacion,tipo_app,SQL,fecha_publicacion,estatus,activo")] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                db.Publicacion.Add(publicacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicacion);
        }

        // GET: Publicacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // POST: Publicacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_publicacion,nombre_app,ruta_origen,servidor,tipo_publicacion,tipo_app,SQL,fecha_publicacion,estatus,activo")] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicacion);
        }

        // GET: Publicacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // POST: Publicacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publicacion publicacion = db.Publicacion.Find(id);
            db.Publicacion.Remove(publicacion);
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
