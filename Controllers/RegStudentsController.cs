using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XUniversity;

namespace XUniversity.Controllers
{
    public class RegStudentsController : Controller
    {
        private StudentsEntities db = new StudentsEntities();

        // GET: RegStudents
        public ActionResult Index()
        {
            return View(db.RegStudents.ToList());
        }

        // GET: RegStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegStudent regStudent = db.RegStudents.Find(id);
            if (regStudent == null)
            {
                return HttpNotFound();
            }
            return View(regStudent);
        }

        // GET: RegStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegStudents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Email,Password,Phone,StudentID,Major,GPA,Credit")] RegStudent regStudent)
        {
            if (ModelState.IsValid)
            {
                db.RegStudents.Add(regStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regStudent);
        }

        // GET: RegStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegStudent regStudent = db.RegStudents.Find(id);
            if (regStudent == null)
            {
                return HttpNotFound();
            }
            return View(regStudent);
        }

        // POST: RegStudents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Email,Password,Phone,StudentID,Major,GPA,Credit")] RegStudent regStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regStudent);
        }

        // GET: RegStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegStudent regStudent = db.RegStudents.Find(id);
            if (regStudent == null)
            {
                return HttpNotFound();
            }
            return View(regStudent);
        }

        // POST: RegStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegStudent regStudent = db.RegStudents.Find(id);
            db.RegStudents.Remove(regStudent);
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
