using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    /// The class for the operation of getting the first n expressions in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class TakeFirst<TType, TContext> : UnaryListExpression<TType, TContext>

    {
        public TakeFirst(IListExpression<TType, TContext> expression,
            IExpression<int, TContext> countExpression) :
            base(expression)
        {
            CountExpression = countExpression;
        }

        public IExpression<int, TContext> CountExpression { get; }

        public override TType[] Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            var count = CountExpression.Interpret(context);

            return list.Length <= count ? list : Expression.Interpret(context).Take(CountExpression.Interpret(context)).ToArray();
        }
    }
}