using DemoApplication_HOTEL.Model;

namespace DemoApplication_HOTEL.Repositories;

public interface IRoomRepository
{

    
}

public class RoomRepository : BaseRepository , IRoomRepository
{
    public RoomRepository(IConfiguration configuration) : base(configuration)
    {

    }

}