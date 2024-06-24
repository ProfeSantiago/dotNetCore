using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorEntityFrameworkDB.Models;

namespace BlazorEntityFrameworkDB.Data
{
    public class PersonasContext : DbContext
    {
        public PersonasContext (DbContextOptions<PersonasContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorEntityFrameworkDB.Models.Personas> Personas { get; set; } = default!;
    }
}
