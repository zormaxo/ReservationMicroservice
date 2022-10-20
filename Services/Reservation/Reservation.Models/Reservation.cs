namespace Reservation.Models;

public class Reservation
{
    public Guid Id { get; set; }

    public DateTime? CheckInDate { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public DateTime? ReservationDate { get; set; }

    public double Amount { get; set; }

    public Guid OwnerContact { get; set; }
}
