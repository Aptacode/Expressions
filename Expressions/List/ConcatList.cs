using System;
using System.Linq;

namespace Aptacode.Expressions.List
{
    public class ConcatList<TType, TContext> : BinaryListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public ConcatList(IListExpression<TType, TContext> lhs, IListExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }

        public override TType[] Interpret(TContext context) =>
            Lhs.Interpret(context).Concat(Rhs.Interpret(context)).ToArray();
    }
}