namespace Aptacode.Expressions.Bool.Expression
{
    public class Or<TContext> : BinaryBoolExpression<TContext>
    {
        public Or(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) : base(lhs, rhs) { }
        public override bool Interpret(TContext context) => Lhs.Interpret(context) || Rhs.Interpret(context);
    }
}