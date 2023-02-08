using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin
{
    internal class AppBuilder
    {
        public void Run()
        {
            Console.WriteLine("Glacier Quick Trippin'");
            Console.WriteLine("..................................................................");

            bool isInputValid;
            string? input;
            bool isOperationValid;
            bool stopApplication = true;

            do
            {
                Console.WriteLine(@"
            QuikTrip Management Systems
            ---------------------------

            1. Add a Store
            2. View Store Dashboard
            3. Generate District Report
            4. Exit
                              ");

                Console.WriteLine("Please enter an option:");
                input = Console.ReadLine();
                isInputValid = !String.IsNullOrWhiteSpace(input);

                isOperationValid = int.TryParse(input, out int inputOption);

                if (!isOperationValid)
                {
                    Console.WriteLine($"Invalid Option: {input}");
                    Console.WriteLine("Please enter a valid option");
                    isInputValid = false;
                }

                if (isInputValid && isOperationValid)
                {
                    switch (inputOption)
                    {
                        case 1:
                            Console.WriteLine("Stored Added");
                            break;
                        case 2:
                            var dashboard = new Dashboard();
                            dashboard.Run();
                            break;
                        case 3:
                            Console.WriteLine("Report Generated");
                            break;
                        case 4:
                            Console.WriteLine("Exiting the application");
                            stopApplication = false;
                            break;
                        default:
                            isInputValid = false;
                            break;
                    }
                }

            } while (stopApplication);

            Console.WriteLine("..................................................................");
        }
    }
}
