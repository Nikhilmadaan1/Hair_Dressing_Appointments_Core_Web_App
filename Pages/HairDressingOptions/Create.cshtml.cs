using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hair_Dressing_Appointments_Core_Web_App.BusinessLayer;
using Hair_Dressing_Appointments_Core_Web_App.Models;

namespace Hair_Dressing_Appointments_Core_Web_App.Pages.HairDressingOptions
{
    public class CreateModel : PageModel
    {
        private readonly Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext _context;

        public CreateModel(Hair_Dressing_Appointments_Core_Web_App.Models.Hair_Dressing_Appointments_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HairDressingOption HairDressingOption { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HairDressingOption.Add(HairDressingOption);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
