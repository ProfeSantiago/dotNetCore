using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCEntityFrameworkDB.Models;

    public class PersonasContext : DbContext
    {
        public PersonasContext (DbContextOptions<PersonasContext> options)
            : base(options)
        {
        }

        public DbSet<MVCEntityFrameworkDB.Models.Personas> Personas { get; set; } = default!;
    }
