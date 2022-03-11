namespace Aptacode.Expressions.List;

/// <summary>
///     The class for a conditional list expression of any type.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record ConditionalListExpression<TType, TContext>(IExpression<bool, TContext> Condition,
    IListExpression<TType, TContext> PassExpression, IListExpression<TType, TContext> FailExpression) :
    TernaryListExpression<bool, TType, TContext>(Condition,
        PassExpression, FailExpression)

{
    /// <summary>
    ///     Constructor to initialise a conditional list expression.
    /// </summary>
    /// <param name="Condition">The boolean expression to be evaluated.</param>
    /// <param name="PassExpression">The list expression returned on the condition evaluating to true.</param>
    /// <param name="FailExpression">The list expression returned on the condition evaluating to false.</param>
    public override TType[] Interpret(TContext context)
    {
        return Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}