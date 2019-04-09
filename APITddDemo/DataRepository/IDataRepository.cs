using APITddDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITddDemo.DataRepository
{
    public interface IDataRepository/*<TEntity>*/
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void Add(Employee entity);
        void Update(Employee employee, Employee entity);
        void Delete(Employee employee);
    }
}
