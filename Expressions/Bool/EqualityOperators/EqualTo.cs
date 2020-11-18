using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class EqualTo<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public EqualTo(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) == 0;
    }
}