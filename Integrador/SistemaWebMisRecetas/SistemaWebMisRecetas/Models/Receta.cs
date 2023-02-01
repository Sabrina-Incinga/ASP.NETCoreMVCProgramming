using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression("^[d][e][s][a][y][u][n][o]$", ErrorMessage ="Sólo se admite la categoría desayuno")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }
        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public Autor Autor { get; set; }
    }
}
