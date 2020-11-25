using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    public class Last<TType, TContext> : UnaryListItemExpression<TType, TContext>

    {
        public Last(IListExpression<TType, TContext> expression) : base(expression) { }

        public override TType Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length != 0 ? list.Last() : default;
        }
    }
}