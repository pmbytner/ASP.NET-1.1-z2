using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_22._10._09.Models;

namespace ASP.NET_22._10._09.Data
{
    public class ASPNET_22_10_09Context : DbContext
    {
        public ASPNET_22_10_09Context (DbContextOptions<ASPNET_22_10_09Context> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_22._10._09.Models.Miasto> Miasto { get; set; } = default!;
    }
}
