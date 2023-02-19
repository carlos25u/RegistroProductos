using Microsoft.EntityFrameworkCore;
using RegistroProductos.Modelos;

namespace RegistroProductos.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Empleados> Empleados { get; set; }
    }
}
