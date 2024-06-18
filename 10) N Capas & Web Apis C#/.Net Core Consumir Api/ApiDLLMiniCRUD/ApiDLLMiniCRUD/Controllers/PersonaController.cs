using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibClasesDLL;

namespace ApiDLLMiniCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        ClasePersonaDB objetoPersona = new ClasePersonaDB();

        //Ejemplo: https://localhost:44375/api/Persona
        [HttpGet]
        public List<ModeloPersonas> Get()
        {
            try
            {
                return objetoPersona.Cons_Personas().ToList();
            }
            catch (Exception ex)
            {
                return new List<ModeloPersonas>();
            }
        }

        //Ejemplo: https://localhost:44375/api/Persona/8/Megatron/0000-0000/Cybertron/megatron@malillos.com
        [HttpGet("{Cedula}/{Nombre}/{Telefono}/{Direccion}/{Correo}", Name = "Ins_Personas")]
        public List<ModeloPersonas> Ins_Personas(string Cedula, string Nombre, string Telefono, string Direccion, string Correo)
        {
            try
            {
                ModeloPersonas unaPesona = new ModeloPersonas();
                unaPesona.Cedula = Cedula;
                unaPesona.Nombre = Nombre;
                unaPesona.Telefono = Telefono;
                unaPesona.Direccion = Direccion;
                unaPesona.Correo = Correo;
                objetoPersona.Ins_Personas(unaPesona);
                return objetoPersona.Cons_Personas().ToList();
            }
            catch (Exception ex)
            {
                return new List<ModeloPersonas>();
            }
        }//Fin Guarda_Linea ------------------------------------------------
    }
}
