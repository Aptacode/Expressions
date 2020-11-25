using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
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