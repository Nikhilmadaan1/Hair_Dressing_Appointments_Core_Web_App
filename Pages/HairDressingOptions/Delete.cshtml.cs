using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hair_Dressing_Appointments_Core_Web_App.BusinessLayer;
using Hair_Dressing_Appointments_Core_Web_App.Models;

namespace Hair_Dressing_Appointments_Core_Web_App.Pages.HairDressingOptions
{
    public class DeleteModel : PageModel
    {
        private readonly Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext _context;

        public DeleteModel(Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HairDressingOption HairDressingOption { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HairDressingOption = await _context.HairDressingOption.FirstOrDefaultAsync(m => m.Id == id);

            if (HairDressingOption == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HairDressingOption = await _context.HairDressingOption.FindAsync(id);

            if (HairDressingOption != null)
            {
                _context.HairDressingOption.Remove(HairDressingOption);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
