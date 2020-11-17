using System;

namespace Aptacode.Expressions.Numeric
{
    public interface ITerminalNumericExpression<TType, TContext> : IExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType> { }
}