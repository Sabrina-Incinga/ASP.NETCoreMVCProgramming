using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class ValidarEdadAttribute : ValidationAttribute
    {
        public ValidarEdadAttribute()
        {
            ErrorMessage = "El autor debe ser mayor de 18 años";
        }

        public override bool IsValid(object value)
        {
            int edad = (int)value;
            if(edad < 18)
            {
                return false;
            }
            return true;
        }
    }
}
