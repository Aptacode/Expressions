using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Guid
{
    public abstract class TerminalGuidExpression<TContext> : IGuidExpression<TContext> where TContext : IContext
    {
        public abstract System.Guid Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}