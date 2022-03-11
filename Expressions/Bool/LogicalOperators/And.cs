using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators;

/// <summary>
///     The class for the boolean conditional logical operator '<c>&&</c>' on boolean expressions.
/// </summary>
public record And<TContext>
    (IExpression<bool, TContext> Lhs, IExpression<bool, TContext> Rhs) : BinaryExpression<bool, TContext>(Lhs, Rhs)
{
    public override bool Interpret(TContext context)
    {
        return Lhs.Interpret(context) && Rhs.Interpret(context);
    }
}