using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Double
{
    public abstract class TerminalDoubleExpression<TContext> : IDoubleExpression<TContext> {
        public abstract double Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}