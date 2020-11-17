using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class NaryBoolExpression<TContext> : IExpression<bool, TContext>
    {
        protected NaryBoolExpression(params IExpression<bool, TContext>[] expressions)
        {
            Expressions = expressions;
        }

        public IExpression<bool, TContext>[] Expressions { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}