using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public abstract class NaryBoolExpression<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        protected NaryBoolExpression(params IBooleanExpression<TContext>[] expressions)
        {
            Expressions = expressions;
        }

        public IBooleanExpression<TContext>[] Expressions { get; }

        public abstract bool Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}