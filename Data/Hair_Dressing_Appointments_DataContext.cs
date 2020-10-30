using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hair_Dressing_Appointments_Core_Web_App.BusinessLayer;

namespace Hair_Dressing_Appointments_Core_Web_App.Models
{
    public class Hair_Dressing_Appointments_DataContext : DbContext
    {
        public Hair_Dressing_Appointments_DataContext (DbContextOptions<Hair_Dressing_Appointments_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Appointment> Appointment { get; set; }

        public DbSet<Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Client> Client { get; set; }

        public DbSet<Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDresser> HairDresser { get; set; }

        public DbSet<Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDressingOption> HairDressingOption { get; set; }
    }
}
