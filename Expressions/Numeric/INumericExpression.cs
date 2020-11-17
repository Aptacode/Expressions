using System;

namespace Aptacode.Expressions.Numeric
{
    public interface INumericExpression<TType, TContext> : IExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        new TType Interpret(TContext context);
    }
}