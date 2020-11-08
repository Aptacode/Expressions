using System.Linq;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Utilities;

namespace Aptacode.Expressions.List
{
    public class TakeLast<TContext> : IListExpression<TContext> where TContext : IContext
    {
        public TakeLast(IListExpression<TContext> listExpression, IIntegerExpression<TContext> countExpression)
        {
            ListExpression = listExpression;
            CountExpression = countExpression;
        }

        public IListExpression<TContext> ListExpression { get; }
        public IIntegerExpression<TContext> CountExpression { get; }

        public int[] Interpret(TContext context)
        {
            return ListExpression.Interpret(context).TakeLastItems(CountExpression.Interpret(context)).ToArray();
        }
    }
}