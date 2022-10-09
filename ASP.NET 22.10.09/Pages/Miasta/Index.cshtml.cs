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
    public class IndexModel : PageModel
    {
        private readonly ASP.NET_22._10._09.Data.ASPNET_22_10_09Context _context;

        public IndexModel(ASP.NET_22._10._09.Data.ASPNET_22_10_09Context context)
        {
            _context = context;
        }

        public IList<Miasto> Miasto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Miasto != null)
            {
                Miasto = await _context.Miasto.ToListAsync();
            }
        }
    }
}
