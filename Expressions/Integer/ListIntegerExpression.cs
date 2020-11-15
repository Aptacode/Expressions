using Aptacode.Expressions.List;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Integer
{
    public abstract class ListIntegerExpression<TContext> : IIntegerExpression<TContext> 
    {
        protected ListIntegerExpression(IListExpression<TContext> expression)
        {
            Expression = expression;
        }

        public IListExpression<TContext> Expression { get; }

        public abstract int Interpret(TContext context);

        public void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}