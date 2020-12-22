using _4364.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4364.Interfaces
{
    public interface IReservationRepository
    {
        Reservation CreateReservation(CreateReservationModel model);
    }
}
