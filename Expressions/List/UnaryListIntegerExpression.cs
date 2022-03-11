using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List;

public abstract record UnaryListIntegerExpression<TType, TContext>
    (IListExpression<TType, TContext> Expression) : IExpression<int, TContext>

{
    public abstract int Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}