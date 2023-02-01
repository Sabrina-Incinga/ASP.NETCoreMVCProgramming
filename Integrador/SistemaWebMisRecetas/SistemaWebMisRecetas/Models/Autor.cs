using SistemaWebMisRecetas.Validations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    [Table("Autor")]
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Apellido { get; set; }
        [ValidarEdad]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage ="Formato de email inválido")]
        public string Email { get; set; }
        public List<Receta> Recetas { get; set; }
    }
}
