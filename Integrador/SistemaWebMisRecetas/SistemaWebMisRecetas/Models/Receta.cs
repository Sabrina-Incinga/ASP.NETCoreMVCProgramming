using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        [RegularExpression("^[d][e][s][a][y][u][n][o]$", ErrorMessage ="Sólo se admite la categoría desayuno")]
        public string Categoria { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }
        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public Autor Autor { get; set; }
    }
}
