using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class LessThanOrEqualTo<TContext> : BinaryBoolComparison<TContext> 
    {
        public LessThanOrEqualTo(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) :
            base(lhs, rhs) { }

        public override bool Interpret(TContext context) => Lhs.Interpret(context) <= Rhs.Interpret(context);
    }
}