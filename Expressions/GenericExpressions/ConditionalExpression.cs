namespace Aptacode.Expressions.GenericExpressions
{
    /// <summary>
    /// The class for a conditional expression of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConditionalExpression<TType, TContext> : TernaryExpression<bool, TType, TContext>
    {
        /// <summary>
        /// Constructor to initialise a conditional expression.
        /// </summary>
        /// <param name="condition">The boolean expression to be evaluated.</param>
        /// <param name="passExpression">The expression returned on the condition evaluating to true.</param>
        /// <param name="failExpression">The expression returned on the condition evaluating to false.</param>
        public ConditionalExpression(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression, IExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression) { }

        public override TType Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}