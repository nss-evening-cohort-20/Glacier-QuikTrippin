using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class EmployeeRepository : IRepository<IEmployee>
    {

        static IList<IEmployee> _employees = new List<IEmployee>();
        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public IEmployee Get(int id)
        {
            return _employees.Where(x => x.Id== id).FirstOrDefault();
        }

        public IList<IEmployee> GetAll()
        {
            return _employees;
        }

        public void Update(IEmployee employee)
        {
            var itemToUpdate = _employees.Where(x => x.Id== employee.Id).FirstOrDefault();
            if (itemToUpdate!=null)
            {
                _employees.Remove(itemToUpdate);
                _employees.Add(itemToUpdate);
            }
        }
    }
}
