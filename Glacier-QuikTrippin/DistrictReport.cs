namespace Glacier_QuikTrippin;

public class DistrictReport
{

    public void Report(StoreRepository storeRepository)
    {
        Console.Clear();
        Title.DisplayTitle();
       List<Store> stores = storeRepository.GetStores();
        foreach (var store in stores)
        {
            Console.WriteLine($@"
STORE NO. {store.Number}
---------------
GAS YEARLY: {store.GasYearly}
GAS CURRENT QUARTER: {store.GasCurrentQuarter}
RETAIL YEARLY: {store.RetailYearly}
RETAIL CURRENT QUARTER: {store.RetailCurrentQuarter}")
                ;

        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey(true);
    }
}
