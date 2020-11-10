using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.List
{
    public abstract class TerminalListExpression<TContext> : IListExpression<TContext> where TContext : IContext
    {
        public abstract int[] Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}
