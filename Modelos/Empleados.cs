using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace RegistroProductos.Modelos
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public String? Nombres { get; set; }
        public String? Apellidos { get; set; }
        public String? Celular { get; set; }
        public String? Direccion { get; set; }
    }
}
