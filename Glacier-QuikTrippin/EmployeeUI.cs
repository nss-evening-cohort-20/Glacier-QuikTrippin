using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class EmployeeUI
    {
        int _storeId;
        public EmployeeUI(int storeId)
        {
            _storeId= storeId;
        }

        public IEmployee RenderAddEmployee()
        {
            bool isNameValid = false;
            string name;
            bool isRoleValid = false;
            string role;
            bool isRateValid = false;
            double rate;
            bool isSalesValid = false;
            double sales;

            do
            {
                Console.WriteLine("Employee Name:");
                name = Console.ReadLine();
                isNameValid= !String.IsNullOrWhiteSpace(name);

                if (!isNameValid)
                {
                    Console.WriteLine("Plese enter a valid Name.");
                }
            } while (!isNameValid);


            do
            {
                Console.WriteLine("Role:");
                role = Console.ReadLine();
                isRoleValid = !String.IsNullOrWhiteSpace(role);

                if (!isRoleValid)
                {
                    Console.WriteLine("Plese enter a valid Role.");
                }
            } while (!isRoleValid);


            do
            {
                Console.WriteLine("Pay Rate/Hr:");
                var rateInput = Console.ReadLine();

                isRateValid = !String.IsNullOrWhiteSpace(rateInput);
                isRateValid = double.TryParse(rateInput, out rate);

                if (!isRateValid)
                {
                    Console.WriteLine("Plese enter a valid Rate/Hr.");
                }
            } while (!isRateValid);

            do
            {
                Console.WriteLine("Sales:");
                var salesInput = Console.ReadLine();

                isSalesValid = !String.IsNullOrWhiteSpace(salesInput);
                isSalesValid = double.TryParse(salesInput, out sales);

                if (!isSalesValid)
                {
                    Console.WriteLine("Plese enter a valid Sales Amount.");
                }
            } while (!isSalesValid);

            IEmployee employee = new Employee(storeId: _storeId, name: name, role: role, rate: rate, sales: sales);

            return employee;
        }

        public void RenderViewAllEmployees(IRepository<IEmployee> employeeRepository) {

            Console.WriteLine($"Employees list for store # {_storeId}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            var employeeList = employeeRepository.GetAll().Where(x => x.StoreId == _storeId).ToList();

            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("Press ENTER to go back");

            Console.ReadLine();
        }

    }
}
