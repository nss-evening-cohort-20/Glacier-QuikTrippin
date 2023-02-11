using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class StoreSalesEditor
{
    public void Run(Store store)
    {
        StoreRepository storeRepository = new StoreRepository();
        Console.Clear();
        Title.DisplayTitle();
        int gasYearly = GetIntFromUser("Enter Yearly Gas Sales : $");
        int gasCurrentQuarter = GetIntFromUser("Enter Gas Sales from the Current Quarter: $");
        int retailYearly = GetIntFromUser("Enter Yearly Retail Sales: $");
        int retailCurrentQuarter = GetIntFromUser("Enter Retail Sales from the Current Quarter: $");
        Console.Clear() ;
        Console.WriteLine("Summary of Sales to be added:");
        Console.WriteLine($@"Store Number: {store.Number}
Gas Yearly: ${gasYearly}
Gas Current Quarter: ${gasCurrentQuarter}
Retail Yearly: ${retailYearly}
Retail Current Quarter: ${retailCurrentQuarter}");
        bool userConfirms = ConfirmOrExit();
        if (userConfirms)
        {
            store.GasYearly = gasYearly;
            store.GasCurrentQuarter = gasCurrentQuarter;
            store.RetailYearly= retailYearly;
            store.RetailCurrentQuarter = retailCurrentQuarter;
            Console.WriteLine("store updated. Press Enter to Continue");
            //updates JSON
            storeRepository.updateStore(store);
            Console.ReadLine();
        } else
        {
            Console.WriteLine("Cancelled");
        }

    }
    private int GetIntFromUser(string prompt)
    {

        Console.Write(prompt);
        bool inputWasParsed = int.TryParse(Console.ReadLine(), out int parsedInput);
        while (!inputWasParsed)
        {
            Console.Clear();
            Console.Write($"Try Again! {prompt}");
            inputWasParsed = int.TryParse(Console.ReadLine(), out parsedInput);

        }
        return parsedInput;
    }

    private bool ConfirmOrExit()
    {
        {
            Console.Write("Enter C to Confirm. Enter X to Exit without saving: ");
            string response = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(response) || response != "C" && response != "X")
            {
                Console.Write("Enter C to Confirm. Enter X to Exit without saving: ");
                response = Console.ReadLine();

            }
            if (response == "X") { return false; } else { return true; }

        }
    }
}
