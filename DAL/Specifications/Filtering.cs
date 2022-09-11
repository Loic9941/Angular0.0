using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class Query<TEntity> where TEntity : class
    {
        public static IQueryable<TEntity> Filter(IQueryable<TEntity> inputQuery, IGenericSpecifications<TEntity>? spec = null)
        {
            if (spec != null)
            {
                if (spec.Criteria != null)
                {
                    inputQuery = inputQuery.Where(spec.Criteria);
                }
            }

            return inputQuery;
        }
    }
    
}
