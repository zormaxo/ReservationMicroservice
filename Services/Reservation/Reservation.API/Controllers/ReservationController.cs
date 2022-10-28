using Microsoft.AspNetCore.Mvc;
using Reservation.Infrastructure;

namespace Reservation.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationController : ControllerBase
{
    private readonly IReservationService reservationService;

    public ReservationController(IReservationService ReservationService) { reservationService = ReservationService; }

    [HttpGet]
    public Models.Reservation Get() { return reservationService.GetReservation(); }


    [HttpGet("{Id}")]
    public Models.Reservation GetResById(int Id) { return reservationService.GetReservationById(Id); }
}
