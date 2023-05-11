using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.utilities;
using Dapper;
using DemoApplication_HOTEL.DTOs;

namespace DemoApplication_HOTEL.Repositories;

public interface IGuestRepository
{

    
}

public class GuestRepository : BaseRepository, IGuestRepository
{
    public GuestRepository(IConfiguration configuration) : base(configuration)
    {
    }
}
