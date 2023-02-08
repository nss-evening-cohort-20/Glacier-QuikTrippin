namespace Glacier_QuikTrippin;

public class District
{
    public int Id { get; }

    public DistrictManager DistrictManager { get; set; }


    public District(DistrictRepository districtRepository) 
    {
    
        Id = districtRepository.GetId();
        districtRepository.SaveNewDistrict(this);
    }

 
}
