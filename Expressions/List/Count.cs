using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.List
{
    public class Count<TContext> : IIntegerExpression<TContext> where TContext : IContext
    {
        public Count(IListExpression<TContext> listExpression)
        {
            ListExpression = listExpression;
        }

        public IListExpression<TContext> ListExpression { get; }

        public int Interpret(TContext context) => ListExpression.Interpret(context).Length;
    }
}