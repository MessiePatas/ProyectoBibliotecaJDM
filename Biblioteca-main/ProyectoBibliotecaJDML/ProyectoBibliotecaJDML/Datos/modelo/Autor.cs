using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaJDM.Datos.modelo
{
    public class Autor
    {
        [Key]
        public int  Edad{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  Apodo{ get; set; }
        public string LugarOrigen { get; set; }
    }
}
