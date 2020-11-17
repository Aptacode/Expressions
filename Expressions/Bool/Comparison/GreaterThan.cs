using System;
using System.Collections.Generic;
using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class GreaterThan<TType, TContext> : BinaryBoolComparison<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public GreaterThan(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) > 0;
    }
}