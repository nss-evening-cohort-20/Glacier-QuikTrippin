namespace Glacier_QuikTrippin;

public class DistrictManager
{
    public Dictionary<int, string> ManagerDictionary= new Dictionary<int, string>()
    {
        {1234, "Robert" },
        {5678, "Ganesh" },
        {9012, "Jeremy" }
    };

    public List<string> ListOfManagers()
    {
        List<string> managerList = new List<string>();
        foreach (var manager in ManagerDictionary)
        {
            managerList.Add(manager.Value);
        }
        return managerList;
    }
}
