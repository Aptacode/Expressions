using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions;

public abstract record BinaryExpression<TType, TContext>(IExpression<TType, TContext> Lhs,
    IExpression<TType, TContext> Rhs) : IExpression<TType, TContext>
{
    public abstract TType Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}