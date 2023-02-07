using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

public class Store
{
   public int Number { get; set; }
   public int GasYearly { get; set; }
   public int GasCurrentQuarter { get; set; }
   public int RetailYearly { get; set; }
   public int RetailCurrentQuarter { get;set; }

    Dictionary<string, List<int>>  StoreEmployees{ get;}

    public Store() {
    StoreEmployees= new Dictionary<string, List<int>>();
    }
}
