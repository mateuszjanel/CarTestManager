using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ITestRepository
    {
        Test Create(Car car, float toHundred, float acceleration);
        void Add(Test test);
        void Edit(Test test);
        void Delete(int? id);
        Test Get(int? id);
        List<Test> GetAll();
    }
}
