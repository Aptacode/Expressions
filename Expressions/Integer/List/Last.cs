using System.Linq;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Integer.List
{
    public class Last<TContext> : ListIntegerExpression<TContext> where TContext : IContext
    {
        public Last(IListExpression<TContext> expression) : base(expression) { }

        public override int Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length == 0 ? 0 : list.Last();
        }
    }
}