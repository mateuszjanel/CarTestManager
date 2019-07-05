using DatabaseLayer;
using DatabaseLayer.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class TestRepository : ITestRepository
    {
        DBContext db = new DBContext();
        public Test Create(Car car, float toHundred, float acceleration)
        {
            Test test = new Test
            {
                Car = car,
                TimeToHundred = toHundred,
                Acceleration = acceleration
            };
            Add(test);
            return test;
        }
        public void Add(Test test)
        {
            try
            {
                db.Tests.Add(test);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public void Edit(Test test)
        {
            try
            {
                db.Entry(test).State = EntityState.Modified;
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
                Test test = db.Tests.Find(id);
                db.Tests.Remove(test);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        public Test Get(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Null argument");
            }
            try
            {
                Test test = db.Tests.Find(id);
                return test;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public List<Test> GetAll()
        {
            try
            {
                return db.Tests.ToList();
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
    }
}
