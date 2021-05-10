using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.RelationalOperators
{
    /// <summary>
    ///     The class for the boolean relational operator '<c>&gt;</c>' on expressions of a given type.
    /// </summary>
    /// <remarks>
    ///     Expressions must be of the same type for relations to be defined on them. <br />
    ///     Care should be taken to ensure type comparison can be done on the given type.
    /// </remarks>
    public class GreaterThan<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public GreaterThan(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns>True if lhs <c>&gt;</c> rhs, otherwise false.</returns>
        public override bool Interpret(TContext context)
        {
            return Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) > 0;
        }


        #region IEquatable

        public override bool Equals(object obj) => obj is GreaterThan<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<bool, TContext> other) => other is GreaterThan<TType, TContext> expression && expression == this;

        public static bool operator ==(GreaterThan<TType, TContext> lhs, GreaterThan<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(GreaterThan<TType, TContext> lhs, GreaterThan<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}