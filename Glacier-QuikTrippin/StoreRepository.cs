using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glacier_QuikTrippin;

 public class StoreRepository
{
    static List<Store> _stores = new List<Store>();

    public  List<Store> GetStores()
    {
        return _stores;
    }
    public StoreRepository()
    {
       _stores =  JsonConvert.DeserializeObject<List<Store>>((File.ReadAllText(@"C:\Users\Jeremy White\Workspace E20\Glacier-QuikTrippin\Glacier-QuikTrippin\database\stores.json")));   }

    public void AddStore(Store store)
    {
        _stores.Add(store);
        // serialize JSON to a string and then write string to a file
        File.WriteAllText(@"C:\Users\Jeremy White\Workspace E20\Glacier-QuikTrippin\Glacier-QuikTrippin\database\stores.json", JsonConvert.SerializeObject(_stores.ToArray()));
    }
     
    public bool CheckIfStoreNumberExists(int num)
    {
        List<Store> StoreWithSameNumber = _stores.Where(store => store.Number == num).ToList();

        if (StoreWithSameNumber.Count == 0) return false;
        else return true;
    }
    public Store GetStoreByNumber(int number)
    {
        return _stores.FirstOrDefault(s => s.Number == number);
    }

    public void updateStore(Store store)
    {
        List<Store> copyOfStores = _stores;
        int currentStoreIndex = copyOfStores.FindIndex(s => s.Number == store.Number);

        copyOfStores[currentStoreIndex] = store;

        _stores= copyOfStores;
        

        File.WriteAllText(@"C:\Users\Jeremy White\Workspace E20\Glacier-QuikTrippin\Glacier-QuikTrippin\database\stores.json", JsonConvert.SerializeObject(_stores.ToArray()));

    }
}
