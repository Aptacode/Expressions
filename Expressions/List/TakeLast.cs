using System.Linq;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Utilities;

namespace Aptacode.Expressions.List
{
    public class TakeLast<TContext> : UnaryListExpression<TContext> where TContext : IContext
    {
        public TakeLast(IListExpression<TContext> expression, IIntegerExpression<TContext> countExpression) : base(expression)
        {
            CountExpression = countExpression;
        }

        public IIntegerExpression<TContext> CountExpression { get; }

        public override int[] Interpret(TContext context) => Expression.Interpret(context)
            .TakeLastItems(CountExpression.Interpret(context)).ToArray();
    }
}