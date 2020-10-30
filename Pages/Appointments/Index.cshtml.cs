using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hair_Dressing_Appointments_Core_Web_App.BusinessLayer;
using Hair_Dressing_Appointments_Core_Web_App.Models;

namespace Hair_Dressing_Appointments_Core_Web_App.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext _context;

        public IndexModel(Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment
                .Include(a => a.Client)
                .Include(a => a.HairDresser)
                .Include(a => a.HairDressingOption).ToListAsync();
        }
    }
}
