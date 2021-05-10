using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    ///     The class for the boolean logical operator '<c>!</c>' on boolean expressions.
    /// </summary>
    public class Not<TContext> : UnaryExpression<bool, TContext>
    {
        public Not(IExpression<bool, TContext> expression) : base(expression)
        {
        }

        public override bool Interpret(TContext context)
        {
            return !Expression.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is Not< TContext> expression && Equals(expression);

        public override bool Equals(IExpression<bool, TContext> other) => other is Not< TContext> expression && expression == this;
        public static bool operator ==(Not< TContext> lhs, Not< TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression);
        }

        public static bool operator !=(Not< TContext> lhs, Not< TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}