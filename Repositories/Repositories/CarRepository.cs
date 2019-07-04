using DatabaseLayer;
using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepository
    {
        private DBContext db = new DBContext();
        public Car Create(string make, string model, int year, string engine, float? fuelconsuming)
        {
            Car car = new Car
            {
                Make = make,
                Model = model,
                Year = year,
                Engine = engine,
                FuelConsumingPer100km = fuelconsuming
            };
            Add(car);
            return car;
        }
        public void Add(Car car)
        {
            try
            {
                db.Cars.Add(car);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public void Edit(Car car)
        {
            try
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public void Delete(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Null argument");
            }
            try
            {
                Car car = db.Cars.Find(id);
                db.Cars.Remove(car);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }
        public Car Get(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Null argument");
            }
            try
            {
                Car car = db.Cars.Find(id);
                return car;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public List<Car> GetAll()
        {
            try
            {
                return db.Cars.ToList();
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
        public List<Test> GetTests(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Null argument");
            }
            try
            {
                return db.Cars.Find(id).Tests.ToList();
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
    }
}
