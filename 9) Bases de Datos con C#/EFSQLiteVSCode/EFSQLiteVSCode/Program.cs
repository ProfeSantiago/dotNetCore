using System;
using System.Linq;

using var db = new PersonasContext();
Console.WriteLine($"Database path: {db.DbPath}.");

Console.WriteLine("Insertando una nueva Persona");
db.Add(new Persona {PersonaId=1, Cedula="0-0000-0000", 
Nombre="Eleuterio Garita", Telefono="8888-8888", 
Direccion="Jumanji", Correo="EG@wacanda.wk"});
db.SaveChanges();

Console.WriteLine("Consultando la primera Persona");
var persona = db.Personas.OrderBy(b => b.PersonaId).First();
Console.WriteLine(persona.PersonaId+ " " + persona.Nombre);

db.Remove(persona);
db.SaveChanges();