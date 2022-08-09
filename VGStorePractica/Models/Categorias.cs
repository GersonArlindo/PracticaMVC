using System.ComponentModel.DataAnnotations;

namespace VGStorePractica.Models
{
    public class Categorias
    {
        [Key] 
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
    }
}
