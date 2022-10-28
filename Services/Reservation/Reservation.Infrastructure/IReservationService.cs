﻿
namespace Reservation.Infrastructure;

public interface IReservationService
{
    public void Create(Models.Reservation Reservation);

    public Models.Reservation GetReservation();

    public Models.Reservation GetReservationById(int Id);
}
