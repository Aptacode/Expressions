using System.Linq;
using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.List
{
    public class TakeFirst<TContext> : IListExpression<TContext> where TContext : IContext
    {
        public TakeFirst(IListExpression<TContext> listExpression, IIntegerExpression<TContext> countExpression)
        {
            ListExpression = listExpression;
            CountExpression = countExpression;
        }

        public IListExpression<TContext> ListExpression { get; }
        public IIntegerExpression<TContext> CountExpression { get; }

        public int[] Interpret(TContext context)
        {
            return ListExpression.Interpret(context).Take(CountExpression.Interpret(context)).ToArray();
        }
    }
}