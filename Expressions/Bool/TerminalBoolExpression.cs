using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class TerminalBoolExpression<TContext> : IExpression<bool, TContext>
    {
        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}