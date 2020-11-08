using System.Linq;
using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.List
{
    public class TakeFirst<TContext> : UnaryListExpression<TContext> where TContext : IContext
    {
        public TakeFirst(IListExpression<TContext> expression, IIntegerExpression<TContext> countExpression) : base(expression)
        {
            CountExpression = countExpression;
        }
        public IIntegerExpression<TContext> CountExpression { get; }

        public override int[] Interpret(TContext context) =>
            Expression.Interpret(context).Take(CountExpression.Interpret(context)).ToArray();
    }
}