using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class DistrictDashboard
{
    public int Run(string districtManager)
    {
        Console.WriteLine($"Welcome {districtManager}");
        string prompt = "Please use the arrows keys to navigate the menu. Press enter to make a selection.";
        string[] options = { "Add a Store", "Store Dashboard", "Generate District Report", "Back to District Selection" };

        Menu DistrictDashboardMenu = new Menu(prompt, options);

        int userChosenOption = DistrictDashboardMenu.Run();

        switch (userChosenOption)
        {
            case 0:
                return 0;
            case 1:
                return 1;//find a way to choose the next thing to run
            case 2: return 2;
            default: return 3;
        }


    }
}
