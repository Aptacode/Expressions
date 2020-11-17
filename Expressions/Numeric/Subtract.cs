using System;

namespace Aptacode.Expressions.Numeric
{
    public class Subtract<TType, TContext> : BinaryNumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public Subtract(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 - dynamic2;
        }
    }
}