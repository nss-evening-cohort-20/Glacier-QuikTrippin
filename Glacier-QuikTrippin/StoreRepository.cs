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

    public void AddStore(Store store)
    {
        _stores.Add(store);
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
    public int GetStoreCount()
    {
        return _stores.Count;
    }
}
