using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Numeric
{
    public class Multiply<TType, TContext> : BinaryExpression<TType, TContext>

    {
        public Multiply(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs) { }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 * dynamic2;
        }
    }
}