using DemoApplication_HOTEL.DTOs;
using DemoApplication_HOTEL.Models;
using DemoApplication_HOTEL.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace DemoApplication_HOTEL.Controllers;


[ApiController]
[Route("api/guest")]
public class GuestController : ControllerBase
{

    private readonly ILogger<GuestController > _logger;

    private readonly IGuestRepository _guestRepository;

    private readonly IScheduleRepository _scheduleRepository;

    public GuestController(ILogger<GuestController> logger,IGuestRepository guestRepository,IScheduleRepository scheduleRepository
    )
    {
        _logger = logger;
        _guestRepository = guestRepository;
        _scheduleRepository=scheduleRepository;
    }





}
