using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Examen2.Model;
using Examen2;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private readonly ExamenDbContext _context;

        public EquipmentsController(ExamenDbContext context)
        {
            _context = context;
        }

        // GET: api/Equipments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipments>>> GetEquipments()
        {
            return await _context.Equipments.ToListAsync();
        }

        // GET: api/Equipments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipments>> GetEquipments(long id)
        {
            var equipments = await _context.Equipments.FindAsync(id);

            if (equipments == null)
            {
                return NotFound();
            }

            return equipments;
        }

        // PUT: api/Equipments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipments(long id, Equipments equipments)
        {
            if (id != equipments.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Equipments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Equipments>> PostEquipments(Equipments equipments)
        {
            _context.Equipments.Add(equipments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipments", new { id = equipments.Id }, equipments);
        }

        // DELETE: api/Equipments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Equipments>> DeleteEquipments(long id)
        {
            var equipments = await _context.Equipments.FindAsync(id);
            if (equipments == null)
            {
                return NotFound();
            }

            _context.Equipments.Remove(equipments);
            await _context.SaveChangesAsync();

            return equipments;
        }

        private bool EquipmentsExists(long id)
        {
            return _context.Equipments.Any(e => e.Id == id);
        }
    }
}
