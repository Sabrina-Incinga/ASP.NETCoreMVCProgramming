using System;
using System.ComponentModel.DataAnnotations;

namespace MVCEmpleado.Validations
{
    public class ValidaAnioDeNacimientoAttribute : ValidationAttribute
    {
        public ValidaAnioDeNacimientoAttribute()
        {
            ErrorMessage = "El año de nacimiento debe ser posterior al 2000";
        }

        public override bool IsValid(object value)
        {
            DateTime fechaNacimiento = (DateTime)value;
            int year = fechaNacimiento.Year;

            if(year < 2000)
            {
                return false;
            }

            return true;
        }
    }
}
