using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class StoreBuilder
{
    public void Run(string currentManager)
    {
        StoreRepository StoreDB = new StoreRepository();
        bool running = true;
        do
        {
            Console.Clear();
            Title.DisplayTitle();
            Console.WriteLine("Add a Store");
            int storeNumber = GetIntFromUser();
            string location = GetStringFromUser();
            Store newStore = new Store();
            newStore.Number= storeNumber;
            newStore.Location = location;
            newStore.DistrictManager = currentManager;
            StoreDB.AddStore(newStore);
            Console.WriteLine("You Successfully added");
            newStore.PrintStoreAndLocation();
            if (!AddAnotherStore())
            {
                running = false;
            }
             
        }
        while (running);
    }
    private int GetIntFromUser() 
    {
        StoreRepository StoreDB = new StoreRepository();

        Console.Write("Please enter the new store number: ");  
        bool inputWasParsed = int.TryParse(Console.ReadLine(), out int parsedInput);
        bool storeNumberAlreadyTaken = StoreDB.CheckIfStoreNumberExists(parsedInput);
        while (!inputWasParsed || parsedInput > 1000 || parsedInput <= 0 || storeNumberAlreadyTaken) 
        {
            Console.Clear();
            Console.Write("Please enter the stores number (1-1000): ");
            inputWasParsed = int.TryParse(Console.ReadLine(), out parsedInput);

        }
        return parsedInput;
    }

    private string GetStringFromUser()
    {
        //start by collecting name and validating. 
        Console.Write("Please enter the City Location of the new store: ");
        string city = Console.ReadLine();
        while (String.IsNullOrWhiteSpace(city))
        {
            Console.Clear();
            Console.Write("Please enter the City Location of the new store: ");
            city = Console.ReadLine();

        }
        return city;
    }
    private bool AddAnotherStore()
    {
        Console.Write("Would you like to add another store? Enter Y to add another store and N to return to District Dashboard)");
        string response = Console.ReadLine();
        while (String.IsNullOrWhiteSpace(response) || response != "Y" && response != "N")
        {
            Console.Clear();
            Console.Write("Would you like to add another store? Enter Y to add another store and N to return to District Dashboard");
            response = Console.ReadLine();

        }
        if (response == "N") { return false; } else { return true; }

    }

   
}
