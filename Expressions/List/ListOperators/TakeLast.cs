using System.Linq;
using Aptacode.Expressions.Utilities;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of getting the last m expressions in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class TakeLast<TType, TContext> : UnaryListExpression<TType, TContext>

    {
        public TakeLast(IListExpression<TType, TContext> expression,
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

            if (list.Length <= count)
            {
                return list;
            }

            return Expression.Interpret(context)
                .TakeLastItems(CountExpression.Interpret(context)).ToArray();
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is TakeLast<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType[], TContext> other) => other is TakeLast<TType, TContext> expression && expression == this;
        public static bool operator ==(TakeLast<TType, TContext> lhs, TakeLast<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression) && lhs.CountExpression.Equals(rhs.CountExpression);
        }

        public static bool operator !=(TakeLast<TType, TContext> lhs, TakeLast<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}