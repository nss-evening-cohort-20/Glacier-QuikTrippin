namespace Glacier_QuikTrippin;

public class ManagerDashboard
{
    public string Run()
    {
        string welcomePrompt = "Welcome District Managers. Please make a selection to continue.";
        DistrictManager managers = new DistrictManager();
        List<string> listOfManagers = managers.ListOfManagers();
        listOfManagers.Add("EXIT");
        string[] welcomeOptions = listOfManagers.ToArray();
        Menu welcome = new Menu(welcomePrompt, welcomeOptions);
        int chosenOption = welcome.Run();
        switch (chosenOption)
        {
            case 0:
            return welcomeOptions[0];
                case 1:
                return welcomeOptions[1];
                case 2:
                return welcomeOptions[2];
                case 3: 
                return welcomeOptions[3];
            default:
                return "";
        }

    }
}
