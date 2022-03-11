using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions;

public abstract record UnaryExpression<TType, TContext>
    (IExpression<TType, TContext> Expression) : IExpression<TType, TContext>
{
    public abstract TType Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}