using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VGStorePractica.Models
{
    public class Consolas
    {
        [Key] 
        public int IdConsola { get; set; }
        [Required]
        [DisplayName("Nombre de Consola")]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Descripcion de Consola")]
        public string Descripcion { get; set; }
    }
}
