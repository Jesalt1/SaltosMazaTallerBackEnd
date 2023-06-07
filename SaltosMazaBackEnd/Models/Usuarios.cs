using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaltosMazaBackEnd.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public String Nombre { get; set; }
        [Required]
        [Column(TypeName ="Varchar(20)")]
        public String clave { get; set; }
        public Boolean estado { get; set; }
        public int GeneroId { get; set; } // FK hacia la tabla Genero
        public Genero Genero { get; set; }
    }
}
