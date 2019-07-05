using CarTestManager.Models;
using DatabaseLayer.Entities;
using Repositories.Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarTestManager.Controllers
{
    public class TestController : Controller
    {
        TestRepository testRepository = new TestRepository();
        AccelerationService accelerationService = new AccelerationService();
        // GET: Test
        public ActionResult Index()
        {
            TestMainViewModels model = new TestMainViewModels
            {
                Tests = testRepository.GetAll()
            };
            return View(model);
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test/Create
        public ActionResult Create(int? id) //Id of tested car
        {
            Test model = new Test()
            {
                CarId = (int)id,
            };
            return View(model);
        }

        // POST: Test/Create
        [HttpPost]
        public ActionResult Create(Test model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Acceleration = accelerationService.CalculateAcceleration((float)model.TimeToHundred);
                    testRepository.Add(model);
                    return RedirectToAction("Edit","Car", new { id = model.CarId });
                }
                catch
                {
                    return View(model);
                }
            }
            return View(model);
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
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
