namespace Aptacode.Expressions.GenericExpressions
{
    /// <summary>
    ///     The class for a conditional expression of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConditionalExpression<TType, TContext> : TernaryExpression<bool, TType, TContext>
    {
        /// <summary>
        ///     Constructor to initialise a conditional expression.
        /// </summary>
        /// <param name="condition">The boolean expression to be evaluated.</param>
        /// <param name="passExpression">The expression returned on the condition evaluating to true.</param>
        /// <param name="failExpression">The expression returned on the condition evaluating to false.</param>
        public ConditionalExpression(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression, IExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression)
        {
        }

        public override TType Interpret(TContext context)
        {
            return Condition.Interpret(context)
                ? PassExpression.Interpret(context)
                : FailExpression.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is ConditionalExpression<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType, TContext> other) => other is ConditionalExpression<TType, TContext> expression && expression == this;

        public static bool operator ==(ConditionalExpression<TType, TContext> lhs, ConditionalExpression<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Condition.Equals(rhs.Condition) && lhs.PassExpression.Equals(rhs.PassExpression) && lhs.FailExpression.Equals(rhs.FailExpression);
        }

        public static bool operator !=(ConditionalExpression<TType, TContext> lhs, ConditionalExpression<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}