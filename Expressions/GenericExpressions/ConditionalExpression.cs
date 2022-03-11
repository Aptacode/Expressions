namespace Aptacode.Expressions.GenericExpressions;

/// <summary>
///     The class for a conditional expression of any type.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record ConditionalExpression<TType, TContext>(IExpression<bool, TContext> Condition,
    IExpression<TType, TContext> PassExpression, IExpression<TType, TContext> FailExpression) :
    TernaryExpression<bool, TType, TContext>(Condition,
        PassExpression, FailExpression)
{
    /// <summary>
    ///     Constructor to initialise a conditional expression.
    /// </summary>
    /// <param name="Condition">The boolean expression to be evaluated.</param>
    /// <param name="PassExpression">The expression returned on the condition evaluating to true.</param>
    /// <param name="FailExpression">The expression returned on the condition evaluating to false.</param>
    public override TType Interpret(TContext context)
    {
        return Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}