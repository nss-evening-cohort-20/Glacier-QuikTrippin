namespace Glacier_QuikTrippin;

public class DistrictReport
{

    public void Report(StoreRepository storeRepository, IRepository<IEmployee> districtRepository)
    {

        Console.Clear();
        Title.DisplayTitle();
       List<Store> stores = storeRepository.GetStores();
        foreach (var store in stores)
        {
            Console.WriteLine($@"
---------------
STORE NO. {store.Number}
---------------");
           var employeeList = districtRepository.GetAll().Where(x => x.StoreId == store.Number).ToList();
            foreach (var employee in employeeList)
            {
                
            
            Console.WriteLine($@"
ID: {employee.Id}
NAME: {employee.Name}
ROLE: {employee.Role}
RATE: {employee.Rate}
SALES: {employee.Sales}
")
                ;
}
            Console.WriteLine($@"
GAS YEARLY: {store.GasYearly}
GAS CURRENT QUARTER: {store.GasCurrentQuarter}
RETAIL YEARLY: {store.RetailYearly}
RETAIL CURRENT QUARTER: {store.RetailCurrentQuarter}
");
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey(true);
        Console.Clear();
    }
}

