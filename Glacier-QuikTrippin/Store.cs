using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class Store
{
   public int Number { get; set; }
    public string Location { get; set; }
   public int GasYearly { get; set; }
   public int GasCurrentQuarter { get; set; }
   public int RetailYearly { get; set; }
   public int RetailCurrentQuarter { get;set; }

    //TODO: Replace type int with Employee
    Dictionary<string, List<Employee>>  StoreEmployees{ get;}

    public Store() {
        //TODO: Replace type int with Employee
    StoreEmployees= new Dictionary<string, List<Employee>>();
        Location = "";
    }
    public void PrintStoreAndLocation()
    {
        Console.WriteLine($"Store Number: {Number}, Location: {Location}");
    }
}
