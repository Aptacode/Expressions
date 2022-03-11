using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators;

/// <summary>
///     The class for the boolean logical operator '<c>!</c>' on boolean expressions.
/// </summary>
public record Not<TContext>(IExpression<bool, TContext> Expression) : UnaryExpression<bool, TContext>(Expression)
{
    public override bool Interpret(TContext context)
    {
        return !Expression.Interpret(context);
    }
}