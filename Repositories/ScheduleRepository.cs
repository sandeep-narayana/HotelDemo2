using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.utilities;
using Dapper;

namespace DemoApplication_HOTEL.Repositories;

public interface IScheduleRepository
{

    
}

public class ScheduleRepository : BaseRepository,IScheduleRepository 
{
    public ScheduleRepository(IConfiguration configuration) : base(configuration)
    {

    }


}