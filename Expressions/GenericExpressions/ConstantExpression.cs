using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions;

/// <summary>
///     The class for a constant expression of any type.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record ConstantExpression<TType, TContext>(TType Value) : TerminalExpression<TType, TContext>
{
    public override TType Interpret(TContext context)
    {
        return Value;
    }

    public new void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}