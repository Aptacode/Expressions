using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List;

public abstract record TerminalListExpression<TType, TContext> : IListExpression<TType, TContext>

{
    public abstract TType[] Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}