using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean conditional logical operator '<c>&&</c>' on boolean expressions.
    /// </summary>
    public class And<TContext> : BinaryExpression<bool, TContext>
    {
        public And(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) : base(lhs, rhs)
        {
        }

        public override bool Interpret(TContext context)
        {
            return Lhs.Interpret(context) && Rhs.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is And<TContext> expression && Equals(expression);

        public override bool Equals(IExpression<bool, TContext> other) => other is And<TContext> expression && expression == this;

        public static bool operator ==(And<TContext> lhs, And<TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(And<TContext> lhs, And<TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}