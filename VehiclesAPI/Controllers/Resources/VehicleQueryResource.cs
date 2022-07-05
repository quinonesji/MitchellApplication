namespace VehiclesAPI.Controllers.Resources
{
    public class VehicleQueryResource
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
