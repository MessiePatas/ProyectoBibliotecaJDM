using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaJDM.Datos.modelo;

namespace ProyectoBibliotecaJDM.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
