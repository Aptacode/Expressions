using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class NaryBoolExpression<TContext> : IExpression<bool, TContext>
    {
        public readonly IExpression<bool, TContext>[] Expressions;

        protected NaryBoolExpression(params IExpression<bool, TContext>[] expressions)
        {
            Expressions = expressions;
        }

        public abstract bool Equals(IExpression<bool, TContext> other);
        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}