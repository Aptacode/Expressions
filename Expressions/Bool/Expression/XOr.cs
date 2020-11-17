namespace Aptacode.Expressions.Bool.Expression
{
    public class XOr<TContext> : BinaryBoolExpression<TContext>
    {
        public XOr(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) : base(lhs, rhs) { }
        public override bool Interpret(TContext context) => Lhs.Interpret(context) ^ Rhs.Interpret(context);
    }
}