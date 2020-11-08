using System.Linq;
using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.List
{
    public class Last<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        public Last(IListExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TContext> Expression { get; }

        public int Interpret(TContext context)
        {
            return Expression.Interpret(context).Last();
        }
    }
}