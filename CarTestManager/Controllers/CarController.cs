using CarTestManager.Models;
using DatabaseLayer.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarTestManager.Controllers
{
    [Authorize]
    public class CarController : Controller
    {
        private CarRepository carRepository = new CarRepository();
        // GET: Car
        public ActionResult Index()
        {
            CarModels model = new CarModels
            {
                Cars = carRepository.GetAll()
            };
            return View(model);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            CreateCarModels model = new CreateCarModels();
            return View(model);
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(CreateCarModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Car car = carRepository.Create(model.Make, model.CarModel, model.Year, model.Engine);
                    return RedirectToAction("Edit", new { id = car.Id });
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id != null)
            {
                Car model = carRepository.Get(id);
                return View(model);

            }
            return RedirectToAction("Index");
        }

        // POST: Car/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Car model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    carRepository.Edit(model);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(model);
                }
            }
            return View(model);
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            carRepository.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: Car/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
