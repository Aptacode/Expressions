using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class NotEqualTo<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public NotEqualTo(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) != 0;
    }
}