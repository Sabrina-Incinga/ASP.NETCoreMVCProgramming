using Microsoft.EntityFrameworkCore;
using MVCEmpleado.Models;

namespace MVCEmpleado.Data
{
    public class DBEmpleadosContext : DbContext
    {
        public DBEmpleadosContext(DbContextOptions<DBEmpleadosContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
