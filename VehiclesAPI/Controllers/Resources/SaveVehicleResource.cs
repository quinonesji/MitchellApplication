using System.ComponentModel.DataAnnotations;
using VehiclesAPI.Core.Models;

namespace VehiclesAPI.Controllers.Resources
{
    public class SaveVehicleResource
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Make { get; set; }
        [ValidateVehicleDate]
        public int Year { get; set; }
    }
}
