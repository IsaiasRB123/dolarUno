using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiDolar.Data;
using apiDolar.Models;

namespace apiDolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportacionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExportacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exportacion>>> GetExportacions()
        {
            return await _context.exportacion.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Exportacion>> GetExportacion(int id)
        {
            var exportacion = await _context.exportacion.FindAsync(id);

            if (exportacion == null)
            {
                return NotFound();
            }

            return exportacion;
        }

        [HttpPost]
        public async Task<ActionResult<Exportacion>> PostExportacion([FromBody] Exportacion exportacion)
        {
            _context.exportacion.Add(exportacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExportacion", new { id = exportacion.Id }, exportacion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExportacion(int id, [FromBody] Exportacion exportacion)
        {
            if (id != exportacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(exportacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExportacionExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExportacion(int id)
        {
            var exportacion = await _context.exportacion.FindAsync(id);
            if (exportacion == null)
            {
                return NotFound();
            }

            _context.exportacion.Remove(exportacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExportacionExists(int id)
        {
            return _context.exportacion.Any(e => e.Id == id);
        }
    }
}
