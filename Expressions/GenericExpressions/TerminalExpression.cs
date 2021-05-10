using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public abstract class TerminalExpression<TType, TContext> : IExpression<TType, TContext>
    {
        public abstract bool Equals(IExpression<TType, TContext> other);
        public abstract TType Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}