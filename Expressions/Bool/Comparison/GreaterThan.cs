using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class GreaterThan<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public GreaterThan(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) > 0;
    }
}