using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    {
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly iClubContext _context;
        private IQueryable<T> _entities = null;
        public GenericRepository(iClubContext context)
        {
            _context = context;
            _entities = _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> Get(IGenericSpecs<T>? spec = null)
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
}
