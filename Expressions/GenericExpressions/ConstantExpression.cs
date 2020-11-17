using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    public class ConstantExpression<TType, TContext> : TerminalExpression<TType, TContext>

    {
        public ConstantExpression(TType value)
        {
            Value = value;
        }

        public TType Value { get; }

        public override TType Interpret(TContext context) => Value;

        public void Visit(IExpressionVisitor<TContext> visitor) => visitor.Visit(this);
    }
}