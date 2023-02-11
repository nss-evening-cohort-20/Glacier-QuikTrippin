// See https://aka.ms/new-console-template for more information
using Glacier_QuikTrippin;
using System;

//Console.WriteLine("test1");
//DistrictRepository repository= new DistrictRepository();
//District test =new District(repository);
//District test2=new District(repository);
//District test3=new District(repository);
//var repo = repository.GetDistricts();
//foreach (var item in repo)
//{
//    Console.WriteLine(item.Id);
//}

//Title title = new Title();
//title.DisplayTitle();

//string prompt = "Please use the arrows keys to navigate the menu. Press enter to make a selection.";
//string[] options= { "option1", "option2", "option3" };

//Menu mainMenu = new Menu(prompt, options);
//mainMenu.Run();


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

DistrictDashboard districtDashboard = new DistrictDashboard();
StoreRepository storeRepo = new StoreRepository();
StoreBuilder bldr = new StoreBuilder();

bool districtDashboardRunning = false;
bool storeDashboardRunning = false;
bool appRunning = true;
int userSelectedStoreNumber = 0;


while (appRunning)
{

districtDashboardRunning = true;


    //topLevelMenuRunning = false;
    //districtDashboardRunning = true;



while (districtDashboardRunning)
{
    int userChoice = districtDashboard.Run(1);
    if (userChoice == 0)
    {
        bldr.Run();
    } else if (userChoice == 1)
    {

            Console.Clear();
            Title.DisplayTitle();
        Console.WriteLine("Enter Store Number: ");
        int.TryParse(Console.ReadLine(), out userSelectedStoreNumber);
        districtDashboardRunning = false;
        storeDashboardRunning = true;


        //
    }
}


StoreDashboard storeDashboard = new StoreDashboard();

DistrictManager robert = new DistrictManager();

Title title = new Title();
title.DisplayTitle();
List<string> listOfManagers = robert.ListOfManagers();
listOfManagers.Add("EXIT");

while (storeDashboardRunning)
{
    Store currentStore = storeRepo.GetStoreByNumber(userSelectedStoreNumber);
string welcomePrompt = "Welcome District Managers. Please make a selection to continue.";
string[] welcomeOptions = listOfManagers.ToArray();


Menu welcome = new Menu(welcomePrompt, welcomeOptions);



string prompt = "Please use the arrows keys to navigate the menu. Press enter to make a selection.";
string[] options= { "option1", "option2", "option3" };

    int userChoice = storeDashboard.Run(currentStore);
    if (userChoice == 0) {
        //if user choice is Add employee, run add employee interfactd
    } else if (userChoice == 1)
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

Menu mainMenu = new Menu(prompt, options);
//mainMenu.Run(title);
Passwords welcomePasswords = new Passwords();
string userName = "test";
bool running = true;

while (running)
{
    int welcomeSelection = welcome.Run(title);
    switch (welcomeSelection)


    {
        case 0:
            Console.Clear(); 
            title.DisplayTitle();
            Console.WriteLine($"Welcome {welcomeOptions[0]}.");
            userName = welcomeOptions[0];     
            break;
        case 1:
            Console.Clear();
            title.DisplayTitle();
            Console.WriteLine($"Welcome {welcomeOptions[1]}.");
        userName = welcomeOptions[1];
        break;
        case 2:
            Console.Clear();
            title.DisplayTitle();
            Console.WriteLine($"Welcome {welcomeOptions[2]}.");
        userName = welcomeOptions[2];
        break;
        case 3:
            Environment.Exit(0);
            break;
        default:
        break;

    }



    Console.WriteLine("Please Enter Your Password.");
    Console.Write("PASSWORD:");
    string userEntry = Console.ReadLine();
    bool back = true;
    if(welcomePasswords.CheckPassword(robert, userName, userEntry) == 1)
        {
            break;
        }
    else { 
    while (welcomePasswords.CheckPassword(robert, userName, userEntry) == 0 && back == true)
    {
        string subPrompt = "Incorrect Password. Please enter a valid 4 digit number.";
        string[] menuOptions = { "TRY AGAIN", "BACK" };
        Menu subMenu = new Menu(subPrompt, menuOptions);
        int subMenuSelection = subMenu.Run(title);
        switch (subMenuSelection)
        {
            case 0:
                Console.Clear();
                title.DisplayTitle();
                Console.WriteLine("Please Enter your Password");
                userEntry= Console.ReadLine();

                continue;
                case 1:
                back= false;
                break;
            default:
                break;
        }

        }
    }
    if (welcomePasswords.CheckPassword(robert, userName, userEntry) == 1)
    {
        break;
    }


}
    mainMenu.Run(title);

}


#endregion