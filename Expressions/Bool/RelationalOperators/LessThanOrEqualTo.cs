using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.RelationalOperators
{
    public class LessThanOrEqualTo<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public LessThanOrEqualTo(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }

        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) <= 0;
    }
}