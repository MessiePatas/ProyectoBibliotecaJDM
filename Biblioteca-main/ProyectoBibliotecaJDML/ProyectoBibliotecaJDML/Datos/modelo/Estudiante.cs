using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJDM.Datos.modelo
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
    }
}
