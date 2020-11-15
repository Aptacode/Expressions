using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Color
{
    public abstract class TerminalColorExpression<TContext> : IColorExpression<TContext> 
    {
        public abstract System.Drawing.Color Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}