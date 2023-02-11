using System;

namespace Glacier_QuikTrippin;

public class PasswordDashboard
{
    public int Check(string name)
    {
        Console.Clear();
        Title.DisplayTitle();
        Console.WriteLine("Please Enter Your Password.");
        Console.Write("PASSWORD:");
        string userEntry = Console.ReadLine();

        DistrictManager list = new DistrictManager();
        if (int.TryParse(userEntry, out int password) == false || list.ManagerDictionary.ContainsKey(password) == false || list.ManagerDictionary[password] != name)
        {
            return 0;
        }
        else
        {

            return 1;
        }
    }

    //public void Run()
    //{

    //    Menu passwordDashboard = new Menu();
    //}

}
