using System;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Numeric.List
{
    public class Count<TType, TContext> : UnaryListIntegerExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public Count(IListExpression<TType, TContext> expression) : base(expression) { }

        public override int Interpret(TContext context) => Expression.Interpret(context).Length;
    }
}