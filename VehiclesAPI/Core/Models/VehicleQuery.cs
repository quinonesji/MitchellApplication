using VehiclesAPI.Extensions;

namespace VehiclesAPI.Core.Models
{
    public class VehicleQuery : IQueryObject
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}
