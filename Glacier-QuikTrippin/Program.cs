// See https://aka.ms/new-console-template for more information
using Glacier_QuikTrippin;
using System;


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
string districtManager ="";



while (appRunning)
{
    managerDashboardrunning= true;

    while (managerDashboardrunning)
    {
        string userChoice = managerDashbaord.Run();
        if(userChoice != "")
        {
            districtManager= userChoice;
            managerDashboardrunning = false;
        };
    }

    passwordDashboardRunning= true;

    while (passwordDashboardRunning)
    {
      int userChoice = passwordDashboard.Check(districtManager);
        if(userChoice != 0)
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
        if (userChoice == 0)
        {
            bldr.Run();
        }
        else if (userChoice == 1)
        {

            Console.Clear();
            Title.DisplayTitle();
            Console.WriteLine("Enter Store Number: ");
            int.TryParse(Console.ReadLine(), out userSelectedStoreNumber);
            districtDashboardRunning = false;
            storeDashboardRunning = true;    
        }
        else if (userChoice == 3)
        {
            Console.Clear(); 
            Title.DisplayTitle();
            districtDashboardRunning= false;
            storeDashboardRunning = false;
        }
    }

    StoreDashboard storeDashboard = new StoreDashboard();

    while (storeDashboardRunning)
    {
        Store currentStore = storeRepo.GetStoreByNumber(userSelectedStoreNumber);


        int userChoice = storeDashboard.Run(currentStore);
        if (userChoice == 0)
        {
            //if user choice is Add employee, run add employee interfactd
        }
        else if (userChoice == 1)
        {
            //if user choice is Enter sales numbers, then enter sales numbers.
            StoreRepository repo = new StoreRepository();
            StoreSalesEditor edt = new StoreSalesEditor();

            edt.Run(currentStore);
        }
        else
        {
            storeDashboardRunning = false;
        }
    }


}



#endregion