using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool;

public abstract record BinaryBoolComparison<TType, TContext>(IExpression<TType, TContext> Lhs,
    IExpression<TType, TContext> Rhs) : IExpression<bool, TContext>
{
    public abstract bool Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}