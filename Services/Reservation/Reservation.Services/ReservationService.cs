using Reservation.Infrastructure;

namespace Reservation.Services;

public class ReservationService : IReservationService
{
    public void Create(Models.Reservation Reservation)
    {
        // TODO Creation Stuff
    }

    public Models.Reservation GetReservation()
    {
        return new Models.Reservation()
        {
            Id = 5,
            ReservationDate = DateTime.Now,
            CheckInDate = DateTime.Now.Date.AddDays(30),
            CheckOutDate = DateTime.Now.Date.AddDays(37),
            OwnerContact = Guid.NewGuid(),
            Amount = (new Random()).Next(1000, 10000)
        };
    }

    public Models.Reservation GetReservationById(int Id)
    {
        return new Models.Reservation()
        {
            Id = Id,
            ReservationDate = DateTime.Now,
            CheckInDate = DateTime.Now.Date.AddDays(30),
            CheckOutDate = DateTime.Now.Date.AddDays(37),
            OwnerContact = Guid.NewGuid(),
            Amount = (new Random()).Next(1000, 10000)
        };
    }
}
