using System;
using System.Collections.Generic;
using System.Text;

namespace Aptacode.Expressions.List
{
    public interface IListExpression<TType, TContext> : IExpression<TType[], TContext> where TType : struct, IConvertible, IEquatable<TType>
    {
    }
}
