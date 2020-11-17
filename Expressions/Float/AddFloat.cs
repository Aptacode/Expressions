namespace Aptacode.Expressions.Float
{
    public class AddFloat<TContext> : BinaryFloatExpression<TContext> 
    {
        public AddFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) : base(lhs, rhs) { }

        public override float Interpret(TContext context) => Lhs.Interpret(context) + Rhs.Interpret(context);
    }
}