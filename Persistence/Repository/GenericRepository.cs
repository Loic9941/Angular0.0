using DAL.Specifications;
using Domain.Repository;
using Persistence.Context;

namespace Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BookablesProjectContext _context;
        private IQueryable<T> _entities = null;
        public GenericRepository(BookablesProjectContext context)
        {
            _context = context;
            _entities = _context.Set<T>().AsQueryable();
        }

        

        public IQueryable<T> Get(ISpecifications<T>? spec = null)
        {
            if (spec != null)
            {
                if (spec.Criteria != null)
                {
                    _entities = _entities.Where(spec.Criteria);
                }
            }
            return _entities;
        }
    }
}
