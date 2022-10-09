using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_22._10._09.Data;
using ASP.NET_22._10._09.Models;

namespace ASP.NET_22._10._09.Pages.Miasta
{
    public class EditModel : PageModel
    {
        private readonly ASP.NET_22._10._09.Data.ASPNET_22_10_09Context _context;

        public EditModel(ASP.NET_22._10._09.Data.ASPNET_22_10_09Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Miasto Miasto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasto == null)
            {
                return NotFound();
            }

            var miasto =  await _context.Miasto.FirstOrDefaultAsync(m => m.ID == id);
            if (miasto == null)
            {
                return NotFound();
            }
            Miasto = miasto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Miasto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiastoExists(Miasto.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MiastoExists(int id)
        {
          return _context.Miasto.Any(e => e.ID == id);
        }
    }
}
