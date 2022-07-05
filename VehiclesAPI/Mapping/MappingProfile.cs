using AutoMapper;
using VehiclesAPI.Controllers.Resources;
using VehiclesAPI.Core.Models;

namespace VehiclesAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
            CreateMap<Vehicle, SaveVehicleResource>();
            CreateMap<Vehicle, VehicleResource>();
            // API Resource to Domain
            CreateMap<VehicleQueryResource, VehicleQuery>();
            CreateMap<SaveVehicleResource, Vehicle>()
              .ForMember(v => v.Id, opt => opt.Ignore());
        }
    }
}
