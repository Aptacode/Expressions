using System.Linq;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean conditional logical operator '<c>&&</c>' for any amount of boolean expressions.
    /// </summary>
    public class All<TContext> : NaryBoolExpression<TContext>
    {
        public All(params IExpression<bool, TContext>[] expressions) : base(expressions)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(true,
                (current, booleanExpression) => current && booleanExpression.Interpret(context));
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is All<TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<bool, TContext> other)
        {
            return other is All<TContext> expression && expression == this;
        }

        public static bool operator ==(All<TContext> lhs, All<TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expressions.SequenceEqual(rhs.Expressions);
        }

        public static bool operator !=(All<TContext> lhs, All<TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}