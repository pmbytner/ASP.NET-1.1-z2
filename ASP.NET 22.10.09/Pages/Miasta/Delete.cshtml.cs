using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NET_22._10._09.Data;
using ASP.NET_22._10._09.Models;

namespace ASP.NET_22._10._09.Pages.Miasta
{
    public class DeleteModel : PageModel
    {
        private readonly ASP.NET_22._10._09.Data.ASPNET_22_10_09Context _context;

        public DeleteModel(ASP.NET_22._10._09.Data.ASPNET_22_10_09Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Miasto Miasto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Miasto == null)
            {
                return NotFound();
            }

            var miasto = await _context.Miasto.FirstOrDefaultAsync(m => m.ID == id);

            if (miasto == null)
            {
                return NotFound();
            }
            else 
            {
                Miasto = miasto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Miasto == null)
            {
                return NotFound();
            }
            var miasto = await _context.Miasto.FindAsync(id);

            if (miasto != null)
            {
                Miasto = miasto;
                _context.Miasto.Remove(Miasto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
