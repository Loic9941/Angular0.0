using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{

    public interface IGenericSpecifications<T> where T : class

    {
        Expression<Func<T, bool>> Criteria { get; }

        public void AddCriteria(Expression<Func<T, bool>> NewCriteria);

    }
}
