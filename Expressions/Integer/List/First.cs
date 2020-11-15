using System.Linq;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Integer.List
{
    public class First<TContext> : ListIntegerExpression<TContext> 
    {
        public First(IListExpression<TContext> expression) : base(expression) { }

        public override int Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length == 0 ? 0 : list.First();
        }
    }
}