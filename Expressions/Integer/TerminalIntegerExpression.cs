using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Integer
{
    public abstract class TerminalIntegerExpression<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}