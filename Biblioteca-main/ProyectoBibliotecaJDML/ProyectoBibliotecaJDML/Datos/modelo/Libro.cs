using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJDM.Datos.modelo
{

    public class Libro
    {
        [Key]
        public int NumeroLibro { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
        public int CantidadPaginas { get; set; }

    }
    
}
