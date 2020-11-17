using System;

namespace Aptacode.Expressions.Numeric
{
    public interface ITerminalNumericExpression<TType, TContext> : INumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType> { }
}