using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP.NET_22._10._09.Data;
using ASP.NET_22._10._09.Models;

namespace ASP.NET_22._10._09.Pages.Miasta
{
    public class CreateModel : PageModel
    {
        private readonly ASP.NET_22._10._09.Data.ASPNET_22_10_09Context _context;

        public CreateModel(ASP.NET_22._10._09.Data.ASPNET_22_10_09Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Miasto Miasto { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Miasto.Add(Miasto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
