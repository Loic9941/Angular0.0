using DAL.Specifications;

namespace Domain.Repository
{
    public interface IGenericRepository
    {
        public interface IGenericRepository<T> where T : class
        {
            IQueryable<T> Get(ISpecifications<T>? spec = null);
        }
    }
}
