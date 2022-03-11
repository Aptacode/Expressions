using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List;

public abstract record BinaryListExpression<TType, TContext>(IListExpression<TType, TContext> Lhs,
    IListExpression<TType, TContext> Rhs) : IListExpression<TType, TContext>

{
    public abstract TType[] Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}