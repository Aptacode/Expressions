using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.String
{
    public abstract class TerminalStringExpression<TContext> : IStringExpression<TContext>
    {
        public abstract string Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}