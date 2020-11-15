using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TerminalListExpression<TContext> : IListExpression<TContext> 
    {
        public abstract int[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}