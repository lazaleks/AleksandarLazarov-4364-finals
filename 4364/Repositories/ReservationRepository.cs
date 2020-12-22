using _4364.DataAccess;
using _4364.Interfaces;
using _4364.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4364.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ReservationContext _context;

        public ReservationRepository(ReservationContext context)
        {
            _context = context;
        }

        public Reservation CreateReservation(CreateReservationModel model)
        {
            if (model.Confirmation == false)
                return null;
            else;
            {
                var reservation = new Reservation
                {
                    Name = model.Name,
                    Username = model.Username,
                    Password = model.Password,
                    City = model.City,
                    tUser = model.tUser
                };
                _context.reservation.Add(reservation);
                _context.SaveChanges();

                return reservation;
            }
        }
    }
}
