using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Specifications
{
    public class GenericSpecifications<T> : IGenericSpecifications<T> where T : class
    {
        public GenericSpecifications()
        {
        }
        public GenericSpecifications(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<T, bool>> Criteria { get; set; }

        public void AddCriteria(Expression<Func<T, bool>> NewCriteria)
        {
            if (NewCriteria != null && Criteria != null)
            {
                var OldCriteria = Criteria;
                var paramExpr = Expression.Parameter(typeof(T));
                var exprBody = Expression.And(NewCriteria.Body, OldCriteria.Body);
                exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);
                Criteria = Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
            }
            else if (NewCriteria != null)
            {
                Criteria = NewCriteria;
            }
        }
    }

    internal class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(_parameter);
        }

        internal ParameterReplacer(ParameterExpression parameter)
        {
            _parameter = parameter;
        }
    }
}
