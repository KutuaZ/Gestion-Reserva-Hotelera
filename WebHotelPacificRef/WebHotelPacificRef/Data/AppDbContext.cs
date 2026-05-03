using Microsoft.EntityFrameworkCore;
using WebHotelPacificRef.Models;

namespace WebHotelPacificRef.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Habitacion> Habitaciones { get; set; }



        public DbSet<Cliente> Clientes { get; set; }
        }
    }

