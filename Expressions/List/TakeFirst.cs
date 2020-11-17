using System;
using System.Linq;
using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.List
{
    public class TakeFirst<TType, TContext> : UnaryListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public TakeFirst(IListExpression<TType, TContext> expression,
            INumericExpression<int, TContext> countExpression) :
            base(expression)
        {
            CountExpression = countExpression;
        }

        public INumericExpression<int, TContext> CountExpression { get; }

        public override TType[] Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            var count = CountExpression.Interpret(context);

            if (list.Length <= count)
            {
                return list;
            }

            return Expression.Interpret(context).Take(CountExpression.Interpret(context)).ToArray();
        }
    }
}