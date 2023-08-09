using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Colors Fest",
                Local = "Caxias do Sul",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                QtdPessoas = 650,
                Lote = "1° Lote",
                ImagemUrl = "png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Colors Fest Flowers",
                Local = "Flores da Cunha",
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                QtdPessoas = 350,
                Lote = "2° Lote",
                ImagemUrl = "png"
            }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete {id}";
        }
    }
}
