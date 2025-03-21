using ApiPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private List<Persona> personas;
        public PersonasController() {
            this.personas = new List<Persona>();
            Persona p = new Persona
            {
                IdPersona = 1,
                Nombre = "Alejandro",
                Email = "alex@mail.com",
                Edad = 21
            };
            this.personas.Add(p);
            Persona p1 = new Persona
            {
                IdPersona = 2,
                Nombre = "Lucia",
                Email = "lu@mail.com",
                Edad = 20
            };
            this.personas.Add(p1);
            Persona p2 = new Persona
            {
                IdPersona = 3,
                Nombre = "David",
                Email = "david@mail.com",
                Edad = 22
            };
            this.personas.Add(p2);
            Persona p3 = new Persona
            {
                IdPersona = 4,
                Nombre = "Fernando",
                Email = "fer@mail.com",
                Edad = 21
            };
            this.personas.Add(p3);
        }

        [HttpGet]
        public ActionResult<List<Persona>> Get() {
            return this.personas;
        }
        [HttpGet("{id}")]
        public ActionResult<Persona>Get(int id) {
            return this.personas.FirstOrDefault(x => x.IdPersona == id);
        }
    }
}
