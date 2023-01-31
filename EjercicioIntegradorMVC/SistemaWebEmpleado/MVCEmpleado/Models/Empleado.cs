using MVCEmpleado.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression("^[A]{2}\\d{5}$", ErrorMessage ="El Legajo debe comenzar con AA seguido de 5 números")]
        public string Legajo { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        [ValidaAnioDeNacimiento]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Titulo { get; set; }
    }
}
