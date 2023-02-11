﻿using System;
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
            //Commands for accessing store buillder and Store Sales Editor

            #region Testing Store Builder and Sales Number Editor
            //StoreRepository repo = new StoreRepository();
            //StoreBuilder bldr = new StoreBuilder();
            //bldr.Run(); 

            //StoreSalesEditor edt = new StoreSalesEditor();
            //Store currentStore = repo.GetStoreByNumber(250);
            //edt.Run(currentStore);
            #endregion


            #region Testing Store Dashboard and App Flow

            ManagerDashboard managerDashbaord = new ManagerDashboard();
            PasswordDashboard passwordDashboard = new PasswordDashboard();
            DistrictDashboard districtDashboard = new DistrictDashboard();
            StoreRepository storeRepo = new StoreRepository();
            StoreBuilder bldr = new StoreBuilder();

            bool managerDashboardrunning = false;
            bool passwordDashboardRunning = false;
            bool districtDashboardRunning = false;
            bool storeDashboardRunning = false;
            bool appRunning = true;
            int userSelectedStoreNumber = 0;
            string districtManager = "";



            while (appRunning)
            {
                managerDashboardrunning = true;

                while (managerDashboardrunning)
                {
                    string userChoice = managerDashbaord.Run();
                    if (userChoice != "")
                    {
                        districtManager = userChoice;
                        managerDashboardrunning = false;
                    };
                }

                passwordDashboardRunning = true;

                while (passwordDashboardRunning)
                {
                    int userChoice = passwordDashboard.Check(districtManager);
                    if (userChoice != 0)
                    {
                        passwordDashboardRunning = false;
                    }
                }


                districtDashboardRunning = true;
                //topLevelMenuRunning = false;
                //districtDashboardRunning = true;



                while (districtDashboardRunning)
                {
                    int userChoice = districtDashboard.Run(districtManager);
                    int storeCount = storeRepo.GetStoreCount();
                    if (userChoice == 0)
                    {
                        bldr.Run(districtManager);
                    }
                    else if (userChoice == 1 && storeCount > 0)
                    {
                        bool inputParsed = false;
                        bool storeFound = false;
                        do
                        {

                            Console.Clear();
                            Title.DisplayTitle();
                            Console.WriteLine("Enter Store Number: ");
                            string userInput = Console.ReadLine();
                           // if (userInput == "X") break;
                            inputParsed = int.TryParse(userInput, out userSelectedStoreNumber);
                            storeFound = storeRepo.CheckIfStoreNumberExists(userSelectedStoreNumber);
                        } while (!inputParsed || !storeFound);

                    
                        districtDashboardRunning = false;
                        storeDashboardRunning = true;
                    }
                    else if (userChoice == 1)
                    {
                        Console.Clear();
                        Title.DisplayTitle();
                        Console.WriteLine("No Stores! Press enter and add a store to continue!");
                        Console.ReadLine();

                    }
                    else if (userChoice == 3)
                    {
                        Console.Clear();
                        Title.DisplayTitle();
                        districtDashboardRunning = false;
                        storeDashboardRunning = false;
                    }
                }

                StoreDashboard storeDashboard = new StoreDashboard();
                IRepository<IEmployee> employeeRepository = new EmployeeRepository();

                while (storeDashboardRunning)
                {
                    Store currentStore = storeRepo.GetStoreByNumber(userSelectedStoreNumber);


                    int userChoice = storeDashboard.Run(currentStore);
                    if (userChoice == 0)
                    {
                        //if user choice is Add employee, run add employee interfactd
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

                        IEmployee employee = new Employee(storeId: currentStore.Number, name: name, role: role, rate: rate, sales: sales);
                        employeeRepository.Add(employee);

                    }
                    else if (userChoice == 1)
                    {
                        //if user choice is Enter sales numbers, then enter sales numbers.
                        StoreRepository repo = new StoreRepository();
                        StoreSalesEditor edt = new StoreSalesEditor();

                        edt.Run(currentStore);
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine($"Employees list for store # {currentStore.Number}");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        var employeeList = employeeRepository.GetAll().Where(x => x.StoreId == currentStore.Number).ToList();

                        foreach (var item in employeeList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        storeDashboardRunning = false;
                    }
                }


            }



            #endregion
            //Console.WriteLine("Glacier Quick Trippin'");
            //Console.WriteLine("..................................................................");

            //bool isInputValid;
            //string? input;
            //bool isOperationValid;
            //bool stopApplication = true;

            //do
            //{
            //    Console.WriteLine(@"
            //QuikTrip Management Systems
            //---------------------------

            //1. Add a Store
            //2. View Store Dashboard
            //3. Generate District Report
            //4. Exit
            //                  ");

            //    Console.WriteLine("Please enter an option:");
            //    input = Console.ReadLine();
            //    isInputValid = !String.IsNullOrWhiteSpace(input);

            //    isOperationValid = int.TryParse(input, out int inputOption);

            //    if (!isOperationValid)
            //    {
            //        Console.WriteLine($"Invalid Option: {input}");
            //        Console.WriteLine("Please enter a valid option");
            //        isInputValid = false;
            //    }

            //    if (isInputValid && isOperationValid)
            //    {
            //        switch (inputOption)
            //        {
            //            case 1:
            //                Console.WriteLine("Stored Added");
            //                break;
            //            case 2:
            //                var dashboard = new Dashboard();
            //                dashboard.Run();
            //                break;
            //            case 3:
            //                Console.WriteLine("Report Generated");
            //                break;
            //            case 4:
            //                Console.WriteLine("Exiting the application");
            //                stopApplication = false;
            //                break;
            //            default:
            //                isInputValid = false;
            //                break;
            //        }
            //    }

            //} while (stopApplication);

            //Console.WriteLine("..................................................................");
        }
    }
}
