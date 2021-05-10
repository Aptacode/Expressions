using System.Linq;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean conditional logical operator '<c>||</c>' for any amount of boolean expressions.
    /// </summary>
    public class Any<TContext> : NaryBoolExpression<TContext>
    {
        public Any(params IExpression<bool, TContext>[] expressions) : base(expressions)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(false,
                (current, booleanExpression) => current || booleanExpression.Interpret(context));
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is Any<TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<bool, TContext> other)
        {
            return other is Any<TContext> expression && expression == this;
        }

        public static bool operator ==(Any<TContext> lhs, Any<TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expressions.SequenceEqual(rhs.Expressions);
        }

        public static bool operator !=(Any<TContext> lhs, Any<TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}