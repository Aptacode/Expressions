using System;
using System.Linq;
using Aptacode.Expressions.Numeric;
using Aptacode.Expressions.Utilities;

namespace Aptacode.Expressions.List
{
    public class TakeLast<TType, TContext> : UnaryListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public TakeLast(IListExpression<TType, TContext> expression,
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

            return Expression.Interpret(context)
                .TakeLastItems(CountExpression.Interpret(context)).ToArray();
        }
    }
}