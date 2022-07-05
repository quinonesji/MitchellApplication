using System.Threading.Tasks;
using VehiclesAPI.Core;

namespace VehiclesAPI.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MitchellDbContext context;

        public UnitOfWork(MitchellDbContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
