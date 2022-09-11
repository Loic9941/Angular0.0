using System.Linq.Expressions;

namespace DAL.Specifications
{
    public interface ISpecifications<T> where T : class

    {
        Expression<Func<T, bool>> Criteria { get; }

        public void AddCriteria(Expression<Func<T, bool>> NewCriteria);

    }
}