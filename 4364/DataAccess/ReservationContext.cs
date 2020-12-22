using _4364.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4364.DataAccess
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> reservation { get; set; }
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {

        }
    }
}
