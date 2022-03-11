using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List;

public abstract record TernaryListExpression<T1, T2, TContext>(IExpression<T1, TContext> Condition,
    IListExpression<T2, TContext> PassExpression,
    IListExpression<T2, TContext> FailExpression) : IListExpression<T2, TContext>

{
    public abstract T2[] Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}