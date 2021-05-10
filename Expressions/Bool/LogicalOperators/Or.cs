using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean conditional logical operator '<c>||</c>' on boolean expressions.
    /// </summary>
    public class Or<TContext> : BinaryExpression<bool, TContext>
    {
        public Or(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) : base(lhs, rhs)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Lhs.Interpret(context) || Rhs.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is Or<TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<bool, TContext> other)
        {
            return other is Or<TContext> expression && expression == this;
        }

        public static bool operator ==(Or<TContext> lhs, Or<TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(Or<TContext> lhs, Or<TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}