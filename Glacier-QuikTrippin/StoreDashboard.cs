using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class StoreDashboard
{
    public int Run(Store store)
    {
  
    string prompt = @$"Store Dashboard: {store.Number}   Location: {store.Location}
Please use the arrows keys to navigate the menu. Press enter to make a selection.";
        string[] options = { "Add a New Employee", "Enter Store Sales", "Back to Distric Dashboard" };

        Menu storeDashboardMenu = new Menu(prompt, options);

        int userChosenOption = storeDashboardMenu.Run();

        switch (userChosenOption)
        {
            case 0:
                return 0;
            case 1:
                return 1;//find a way to choose the next thing to run
            default: return 2;
        }


    }
}
