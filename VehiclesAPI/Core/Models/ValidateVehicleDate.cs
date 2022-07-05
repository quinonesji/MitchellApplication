using System.ComponentModel.DataAnnotations;
using VehiclesAPI.Controllers.Resources;

namespace VehiclesAPI.Core.Models
{
    public class ValidateVehicleDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var vehicle = (SaveVehicleResource)validationContext.ObjectInstance;

            if (vehicle.Year == 0)
                return new ValidationResult("Vehicle Date is required.");


            return (1950 <= vehicle.Year && 2050 >= vehicle.Year)
                ? ValidationResult.Success
                : new ValidationResult("Vehicle Year should be between 1950 and 2050.");
        }
    }
}
