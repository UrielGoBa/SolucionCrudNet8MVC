using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base( options)
        {
        }

        //Agregar los modelos aqui (cada modelo corresponde a una tabla en la BD)

        public DbSet<Contacto> Contactos { get; set; }

    }
}
