using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByID(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BkgNumber = BkgNumber,
                Amount = (new Random()).Next(1000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37)

            };
        }
    }
}
