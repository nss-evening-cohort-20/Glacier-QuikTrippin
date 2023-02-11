using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class Dashboard : IDashboard
    {
        public void Run()
        {
            bool isStoreNumberValid;
            string? storeNumberInput;
            int storeNumber;
            bool isStoreNumberOperationValid;

            string? dashboardInput;
            int dashboardInputOption;
            bool isDashboardOperationValid;
            bool isDashboardInputValid;
            bool stopApplication = false;

            IRepository<IEmployee> employeeRepository = new EmployeeRepository();

            do
            {
                Console.WriteLine("Please enter a store number:");
                storeNumberInput = Console.ReadLine();
                isStoreNumberValid = !String.IsNullOrWhiteSpace(storeNumberInput);
                isStoreNumberOperationValid = int.TryParse(storeNumberInput, out storeNumber);

                if (!isStoreNumberOperationValid)
                {
                    Console.WriteLine($"Invalid Store Number: {storeNumber}");
                    isStoreNumberValid = false;
                }

            } while (!isStoreNumberValid);

            do
            {
                Console.WriteLine($@"
            Dashboard for Store # {storeNumber}
            -----------------------------

            1. Add a new Employee
            2. View All Employees
            3. Enter Store Sales
            4. Back to Main Menu
                              ");

                Console.WriteLine("Please enter an option:");
                dashboardInput = Console.ReadLine();
                isDashboardInputValid = !String.IsNullOrWhiteSpace(dashboardInput);

                isDashboardOperationValid = int.TryParse(dashboardInput, out dashboardInputOption);

                if (!isDashboardOperationValid)
                {
                    isDashboardInputValid = false;
                }

                if (isDashboardInputValid && isDashboardOperationValid)
                {
                    switch (dashboardInputOption)
                    {
                        case 1:
                            //Console.WriteLine("Employee Id:");
                            //var id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Name:");
                            var name = Console.ReadLine();
                            Console.WriteLine("Role:");
                            var role = Console.ReadLine();
                            Console.WriteLine("Rate:");
                            var rate = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sales:");
                            var sales = double.Parse(Console.ReadLine());

                            IEmployee employee = new Employee(storeId:storeNumber,name:name,role:role,rate:rate,sales:sales);
                            employeeRepository.Add(employee);

                            break;
                        case 2:
                            Console.WriteLine($"Employees list for store # {storeNumber}");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------");
                            var employeeList = employeeRepository.GetAll().Where(x => x.StoreId == storeNumber).ToList();

                            foreach (var item in employeeList)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("-----------------------------------------------------------------------------------------------");

                            break;
                        case 3:
                            Console.WriteLine("Store Sales Entered");
                            break;
                        case 4:
                            Console.WriteLine("Going Back to Main");
                            stopApplication = true;
                            break;
                        default:
                            isDashboardInputValid = false;
                            break;
                    }
                }

                if (!isDashboardInputValid || !isDashboardOperationValid)
                {
                    Console.WriteLine($"Invalid Option: {dashboardInput}");
                    Console.WriteLine("Please enter a valid option");
                }

            } while (!stopApplication);

        }
    }
}
