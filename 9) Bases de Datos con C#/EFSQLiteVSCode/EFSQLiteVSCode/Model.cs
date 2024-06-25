using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class PersonasContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public string DbPath { get; }

    public PersonasContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "personas.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Persona
{
    public int PersonaId { get; set; }
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Correo { get; set; }
 }
    