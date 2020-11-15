using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions
{
    public interface IExpression<TType, TContext>
    {
        TType Interpret(TContext context);
        void Visit(IExpressionVisitor<TContext> visitor);
    }
}