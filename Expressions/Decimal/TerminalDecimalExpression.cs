using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Decimal
{
    public abstract class TerminalDecimalExpression<TContext> : IDecimalExpression<TContext> {
        public abstract decimal Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}