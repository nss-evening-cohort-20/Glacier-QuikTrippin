using System.Collections.Immutable;

namespace Glacier_QuikTrippin; 
public class DistrictRepository 
{
    static List<District> _districts = new List<District>();
    public List<District> GetDistricts()
    {
       return _districts;
       
    }
    private int _id = 0;

    public int GetId()
    {     
           return _id += 1;
  
    }
        public void SaveNewDistrict(District district)
    {
        _districts.Add(district);
    } 



}
