using Microsoft.AspNetCore.Mvc;
using RapidexAPI.Data;
using RapidexAPI.Models;
using System;
using System.Linq;

namespace RapidexAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class LeadsController : ControllerBase
    {
        private LeadContext _context;

        public LeadsController (LeadContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddLoja([FromBody] Leads leads)
        {
            _context.Leads.Add(leads);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLeadById), new { Id = leads.Id }, leads);

        }

        [HttpGet("{id}")]
        public IActionResult GetLeadById(int id)
        {
            Leads leads = _context.Leads.FirstOrDefault(leads => leads.Id == id);
            if(leads != null)
                return Ok(leads);
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult GetLeads()
        {
            return Ok(_context.Leads);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLeadsById(int id)
        {
            Leads leads = _context.Leads.FirstOrDefault(leads => leads.Id == id);
            if (leads == null)
                return NotFound();
            else
                _context.Remove(leads);
                _context.SaveChanges();
                return NoContent();
        }
    }
}
