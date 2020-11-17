using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Float
{
    public abstract class TerminalFloatExpression<TContext> : IFloatExpression<TContext> {
        public abstract float Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}