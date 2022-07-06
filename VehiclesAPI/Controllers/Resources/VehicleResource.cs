using System;

namespace VehiclesAPI.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
