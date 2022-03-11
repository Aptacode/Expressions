using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List;

public abstract record UnaryListExpression<TType, TContext>
    (IListExpression<TType, TContext> Expression) : IListExpression<TType, TContext>

{
    public abstract TType[] Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}