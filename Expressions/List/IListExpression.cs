using System;

namespace Aptacode.Expressions.List
{
    public interface IListExpression<TType, TContext> : IExpression<TType[], TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        new TType[] Interpret(TContext context);
    }
}