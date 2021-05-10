using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean logical operator '<c>^</c>' on boolean expressions.
    /// </summary>
    public class XOr<TContext> : BinaryExpression<bool, TContext>
    {
        public XOr(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) : base(lhs, rhs)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Lhs.Interpret(context) ^ Rhs.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is XOr<TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<bool, TContext> other)
        {
            return other is XOr<TContext> expression && expression == this;
        }

        public static bool operator ==(XOr<TContext> lhs, XOr<TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(XOr<TContext> lhs, XOr<TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}