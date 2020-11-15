namespace Aptacode.Expressions.Bool.Expression
{
    public class And<TContext> : BinaryBoolExpression<TContext> 
    {
        public And(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) : base(lhs, rhs) { }
        public override bool Interpret(TContext context) => Lhs.Interpret(context) && Rhs.Interpret(context);
    }
}