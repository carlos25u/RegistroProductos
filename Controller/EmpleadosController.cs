using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroProductos.DAL;
using RegistroProductos.Modelos;

namespace RegistroProductos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly Contexto _contexto;

        public EmpleadosController(Contexto contexto)
        {
            _contexto= contexto;    
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> GetEmpleados()
        {
            return await _contexto.Empleados.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Empleados>> GetEmpleados(int id)
        {
            var empleados = await _contexto.Empleados.FindAsync(id);

            if (empleados == null)
            {
                return NotFound();
            }

            return empleados;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleados(int id, Empleados empleados)
        {
            if (id != empleados.EmpleadoId)
            {
                return BadRequest();
            }

            _contexto.Entry(empleados).State = EntityState.Modified;

            try
            {
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Empleados>> PostEmpleados(Empleados empleados)
        {
            _contexto.Empleados.Add(empleados);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction("GetEmpleados", new { id = empleados.EmpleadoId }, empleados);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleados(int id)
        {
            var empleados = await _contexto.Empleados.FindAsync(id);
            if (empleados == null)
            {
                return NotFound();
            }

            _contexto.Empleados.Remove(empleados);
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadosExists(int id)
        {
            return _contexto.Empleados.Any(e => e.EmpleadoId == id);
        }
    }
}
