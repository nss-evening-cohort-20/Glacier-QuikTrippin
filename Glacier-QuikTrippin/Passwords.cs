using System.Collections.Generic;

namespace Glacier_QuikTrippin;

public class Passwords
{

    public int CheckPassword(DistrictManager list, string name, string userEntry)
    {
        //Console.WriteLine("Please Enter Your Password.");
        //Console.Write("PASSWORD:");
        //string userEntry = Console.ReadLine();
        if (int.TryParse(userEntry, out int password) == false || list.ManagerDictionary.ContainsKey(password) == false || list.ManagerDictionary[password] != name )
        {

            //Console.WriteLine("Incorrect Password. Please enter a valid 4 digit number");
            //userEntry= Console.ReadLine();
            //string prompt = "Incorrect Password. Please enter a valid 4 digit number.";
            //string[] menuOptions = { "TRY AGAIN", "BACK" };
            //Title title= new Title();


            //    Menu options = new Menu(prompt, menuOptions);

            //    switch (options.Run(title))
            //    {
            //        case 0:
            //            Console.Clear();
            //        title.DisplayTitle();
            //            Console.WriteLine("Please Enter your Password");
            //            userEntry= Console.ReadLine();
            //            break;
            //    case 1:

            //        break;
            //    default: 
            //            break;
            //    }
            return 0;
        
        }
        else
        {
            return 1;
        }
    }
}
