using System;
using System.Linq;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Numeric.List
{
    public class First<TType, TContext> : UnaryListItemExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public First(IListExpression<TType, TContext> expression) : base(expression) { }

        public override TType Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length == 0 ? default : list.First();
        }
    }
}