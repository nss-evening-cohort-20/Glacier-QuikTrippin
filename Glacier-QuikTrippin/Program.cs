// See https://aka.ms/new-console-template for more information
using Glacier_QuikTrippin;

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


while (storeDashboardRunning)
{
    Store currentStore = storeRepo.GetStoreByNumber(userSelectedStoreNumber);

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


}


#endregion