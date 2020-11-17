using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Guid
{
    public abstract class TerminalGuidExpression<TContext> : IExpression<System.Guid, TContext>
    {
        public abstract System.Guid Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}