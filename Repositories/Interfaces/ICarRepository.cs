using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ICarRepository
    {
        Car Create(string make, string model, int year, string engine, float fuelconsuming);
        void Add(Car car);
        void Edit(Car car);
        void Delete(int? id);
        Car Get(int? id);
        List<Car> GetAll();
        List<Test> GetTests(int? id);
    }
}
