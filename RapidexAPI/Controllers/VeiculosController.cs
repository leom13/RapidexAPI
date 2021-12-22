using Microsoft.AspNetCore.Mvc;
using RapidexAPI.Data;
using RapidexAPI.Models;
using System.Linq;

namespace RapidexAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private VeiculoContext _context;

        public VeiculosController(VeiculoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddLoja([FromBody] Veiculos veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetVeiculoById), new { Id = veiculo.Id }, veiculo);
        }

        [HttpGet]
        public IActionResult GetLojas()
        {
            return Ok(_context.Veiculos);
        }

        [HttpGet("{id}")]
        public IActionResult GetVeiculoById(int id)
        {
            Veiculos veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
            if (veiculo != null)
            {
                return Ok(veiculo);
            }
            return NotFound();
        }

        /*
        [HttpGet("active/{id}")]
        public IActionResult LojasAtivas(bool id)
        {
            Lojas loja = _context.Lojas.Any(loja => loja.Active == id);
         
        }
        */

        [HttpDelete("{id}")]
        public IActionResult DeleteLojaById(int id)
        {
            Veiculos veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Id == id);

            if (veiculo == null)
                return NotFound();
            else
                _context.Remove(veiculo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
