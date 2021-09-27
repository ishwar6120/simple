using KalingaManagementSystem.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KalingaManagementSystem.PresentationLayer.Controllers
{
    public class CampusMindController : Controller
    {
        CampusMindModel cmodel = new CampusMindModel();
        // GET: CampusMind
        public ActionResult Index()
        {
            return View();
        }

        // GET: CampusMind/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CampusMind/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CampusMind/Create
        [HttpPost]
        public ActionResult Create(CampusMindModel cmodel)
        {
            try
            {
                // TODO: Add insert logic here
                ViewData["Name"] = cmodel.Name;
                ViewData["DateOfBirth"] = cmodel.DateOfJoin;
                ViewData["ContactNumber"] = cmodel.ContactNumber;
                ViewData["Address"] = cmodel.Address;
                ViewData["LeadId"] = cmodel.LeadId;


                CampusMindDBHandle chandle = new CampusMindDBHandle();
                chandle.AddCampusMindDetails(cmodel);
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CampusMind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CampusMind/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CampusMind/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CampusMind/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
