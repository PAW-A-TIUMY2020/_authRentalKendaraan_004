using System;
using System.Linq;
using System.Threading.Tasks;
using RentalKendaraan_004.Models;

namespace RentalKendaraan_004.Controllers
{
    internal class PaginatedList<T>
    {
        internal static Task<string> CreateAsync<TEntity>(IQueryable<TEntity> queryable, int v, int pageSize) where TEntity : class
        {
            throw new NotImplementedException();
        }

        internal static Task<string> CreateAsync(IQueryable<Kendaraan> queryable, int v, object pageSize)
        {
            throw new NotImplementedException();
        }
    }
}