using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.GenericArithmeticOperators
{
    public class Add<TType, TContext> : BinaryExpression<TType, TContext>

    {
        public Add(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 + dynamic2;
        }
    }
}