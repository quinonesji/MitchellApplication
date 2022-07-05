using System;

namespace VehiclesAPI.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        //public KeyValuePairResource Model { get; set; }
        //public KeyValuePairResource Make { get; set; }
        //public bool IsRegistered { get; set; }

        //public ContactResource Contact { get; set; }

        public DateTime LastUpdate { get; set; }
        //public ICollection<KeyValuePairResource> Features { get; set; }

        public VehicleResource()
        {
            //Features = new Collection<KeyValuePairResource>();
        }
    }
}
