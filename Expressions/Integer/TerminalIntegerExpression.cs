using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Integer
{
    public abstract class TerminalIntegerExpression<TContext> : IIntegerExpression<TContext> {
        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}