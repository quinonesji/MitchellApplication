using System;
using System.ComponentModel.DataAnnotations;

namespace VehiclesAPI.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
