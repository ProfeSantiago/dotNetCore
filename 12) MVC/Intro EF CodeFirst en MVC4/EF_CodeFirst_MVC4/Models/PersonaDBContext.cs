using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace EF_CodeFirst_MVC4.Models
{
    public class PersonaDBContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

    }//PersonaDBContext

}