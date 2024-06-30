using System;
using System.Linq;

using var db = new PersonasContext();
Console.WriteLine($"Database path: {db.DbPath}.");

Console.WriteLine("Insertando una nueva Persona");
db.Add(new Persona {PersonaId=6, Cedula="0-0000-0000", 
Nombre="Juan", Telefono="8888-8888", 
Direccion="Jumanji", Correo="EG@wacanda.wk"});
db.SaveChanges();

Console.WriteLine("Consultando la primera Persona");
var persona = db.Personas.OrderBy(b => b.PersonaId).First();
Console.WriteLine(persona.PersonaId+ " " + persona.Nombre +" " + persona.Telefono);

db.Remove(persona);
db.SaveChanges();