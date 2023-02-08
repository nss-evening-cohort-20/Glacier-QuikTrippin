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
            bool isInputValid;
            string? input;
            bool isOperationValid;
            bool stopApplication = true;

            do
            {
                Console.WriteLine("Please enter a store number:");
                input = Console.ReadLine();
                isInputValid = !String.IsNullOrWhiteSpace(input);
                isOperationValid = int.TryParse(input, out int inputOption);

                if (!isOperationValid)
                {
                    Console.WriteLine($"Invalid Store Number: {input}");
                    isInputValid = false;
                }

            } while (!isInputValid);

            do
            {
                Console.WriteLine($@"
            Dashboard for Store # {input}
            -----------------------------

            1. Add a new Employee
            2. Enter Store Sales
            3. Back to Main Menu
                              ");

                Console.WriteLine("Please enter an option:");
                input = Console.ReadLine();
                isInputValid = !String.IsNullOrWhiteSpace(input);

                isOperationValid = int.TryParse(input, out int inputOption);

                if (!isOperationValid)
                {
                    isInputValid = false;
                }

                if (isInputValid && isOperationValid)
                {
                    switch (inputOption)
                    {
                        case 1:
                            Console.WriteLine("Employee Added");
                            break;
                        case 2:
                            Console.WriteLine("Store Sales Entered");
                            break;
                        case 3:
                            Console.WriteLine("Going Back to Main");
                            stopApplication = false;
                            break;
                        default:
                            isInputValid = false;
                            break;
                    }
                }

                if (!isInputValid || !isOperationValid)
                {
                    Console.WriteLine($"Invalid Option: {input}");
                    Console.WriteLine("Please enter a valid option");
                }

            } while (stopApplication);

        }
    }
}
