using System.Threading.Tasks;

namespace VehiclesAPI.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
