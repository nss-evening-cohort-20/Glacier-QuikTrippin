// See https://aka.ms/new-console-template for more information
using Glacier_QuikTrippin;
using System;

Console.WriteLine("test1");
DistrictRepository repository= new DistrictRepository();
District test =new District(repository);
District test2=new District(repository);
District test3=new District(repository);
var repo = repository.GetDistricts();
foreach (var item in repo)
{
    Console.WriteLine(item.Id);
}

DistrictManager robert = new DistrictManager();

Title title = new Title();
title.DisplayTitle();
List<string> listOfManagers = robert.ListOfManagers();
listOfManagers.Add("EXIT");

string welcomePrompt = "Welcome District Managers. Please make a selection to continue.";
string[] welcomeOptions = listOfManagers.ToArray();


Menu welcome = new Menu(welcomePrompt, welcomeOptions);



string prompt = "Please use the arrows keys to navigate the menu. Press enter to make a selection.";
string[] options= { "option1", "option2", "option3" };

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

