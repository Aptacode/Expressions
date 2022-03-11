using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions;

public abstract record TernaryExpression<T1, T2, TContext>(IExpression<T1, TContext> Condition,
    IExpression<T2, TContext> PassExpression, IExpression<T2, TContext> FailExpression) : IExpression<T2, TContext>
{
    public abstract T2 Interpret(TContext context);

    public void Visit(IExpressionVisitor<TContext> visitor)
    {
        visitor.Visit(this);
    }
}