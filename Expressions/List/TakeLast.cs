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

        public override int[] Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            var count = CountExpression.Interpret(context);

            if (list.Length <= count)
            {
                return list;
            }
            else
            {
                return Expression.Interpret(context)
                    .TakeLastItems(CountExpression.Interpret(context)).ToArray();
            }
        }

    }
}