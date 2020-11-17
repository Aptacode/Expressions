using System;

namespace Aptacode.Expressions.Numeric
{
    public class Add<TType, TContext> : BinaryNumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public Add(INumericExpression<TType, TContext> lhs, INumericExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 + dynamic2;
        }
    }
}