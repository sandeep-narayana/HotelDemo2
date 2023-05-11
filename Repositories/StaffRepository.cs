using DemoApplication_HOTEL.Models;

namespace DemoApplication_HOTEL.Repositories;

public interface IStaffRepository
{

    
}

public class StaffRepository : BaseRepository,IStaffRepository 
{
    public StaffRepository(IConfiguration configuration) : base(configuration)
    {
        
    }


}