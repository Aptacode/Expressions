namespace Aptacode.Expressions.String
{
    public abstract class Concat<TContext> : BinaryStringExpression<TContext>
    {
        protected Concat(IStringExpression<TContext> lhs, IStringExpression<TContext> rhs) : base(lhs, rhs) { }

        public override string Interpret(TContext context) => Lhs.Interpret(context) + Rhs.Interpret(context);
    }
}