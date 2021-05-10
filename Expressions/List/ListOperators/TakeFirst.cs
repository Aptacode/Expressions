using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of getting the first n expressions in a list expression.
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


        #region IEquatable

        public override bool Equals(object obj) => obj is TakeFirst<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType[], TContext> other) => other is TakeFirst<TType, TContext> expression && expression == this;
        public static bool operator ==(TakeFirst<TType, TContext> lhs, TakeFirst<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression) && lhs.CountExpression.Equals(rhs.CountExpression);
        }

        public static bool operator !=(TakeFirst<TType, TContext> lhs, TakeFirst<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}