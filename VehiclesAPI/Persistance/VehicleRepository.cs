using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehiclesAPI.Core;
using VehiclesAPI.Core.Models;
using VehiclesAPI.Extensions;

namespace VehiclesAPI.Persistance
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly MitchellDbContext _context;

        public VehicleRepository(MitchellDbContext context)
        {
            _context = context;
        }
        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public void Add(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            _context.Remove(vehicle);
        }

        public async Task<QueryResult<Vehicle>> GetVehicles(VehicleQuery queryObj)
        {
            var result = new QueryResult<Vehicle>();

            var query = _context.Vehicles
                .AsQueryable();

            if (queryObj.Year.HasValue)
                query = query.Where(v => v.Year == queryObj.Year);

            if (!string.IsNullOrEmpty(queryObj.Make))
                query = query.Where(v => v.Make == queryObj.Make);

            if (!string.IsNullOrEmpty(queryObj.Model))
                query = query.Where(v => v.Model == queryObj.Model);

            var columnsMap = new Dictionary<string, Expression<Func<Vehicle, object>>>()
            {
                ["make"] = v => v.Make,
                ["model"] = v => v.Model,
                ["Year"] = v => v.Year
            };

            query = query.ApplyOrdering(queryObj, columnsMap);

            result.TotalItems = await query.CountAsync();

            query = query.ApplyPaging(queryObj);

            result.Items = await query.ToListAsync();

            return result;
        }
    }
}
