using Microsoft.AspNetCore.Mvc;
using RapidexAPI.Data;
using RapidexAPI.Models;
using System.Linq;

namespace RapidexAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LojasController : ControllerBase
    {
        private LojaContext _context;

        public LojasController (LojaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddLoja([FromBody]Lojas loja)
        {
            _context.Lojas.Add(loja);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLojaById), new {Id = loja.Id}, loja);
        }

        [HttpGet]
        public IActionResult GetLojas()
        {
            return Ok(_context.Lojas);
        }

        [HttpGet("{id}")]
        public IActionResult GetLojaById(int id)
        {
            Lojas loja = _context.Lojas.FirstOrDefault(loja => loja.Id == id);
            if(loja != null)
            {
                return Ok(loja);
            }
            return NotFound();
        }
       
        
        [HttpGet("active/{id}")]
        public IActionResult LojasAtivas(bool id)
        {
            Lojas loja = _context.Lojas.FirstOrDefault(loja => loja.Active == id);
            if(loja !=null)
                return Ok(loja);
            else
                return NotFound();
         
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLojaById(int id)
        {
            Lojas loja = _context.Lojas.FirstOrDefault(loja =>loja.Id == id);

            if (loja == null)
                return NotFound();
            else
                _context.Remove(loja);
                _context.SaveChanges();
                return NoContent();
        }

    }
}
