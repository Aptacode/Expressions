using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.EqualityOperators
{
    /// <summary>
    ///     The class for the boolean equality operator '<c>!=</c>' on expressions of a given type.
    /// </summary>
    /// <remarks>Expressions must be of the same type for equality to be defined on them.</remarks>
    public class NotEqualTo<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public NotEqualTo(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) != 0;
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is NotEqualTo<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<bool, TContext> other) => other is NotEqualTo<TType, TContext> expression && expression == this;

        public static bool operator ==(NotEqualTo<TType, TContext> lhs, NotEqualTo<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(NotEqualTo<TType, TContext> lhs, NotEqualTo<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}