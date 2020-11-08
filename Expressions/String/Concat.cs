namespace Aptacode.Expressions.String
{
    public abstract class Concat<TContext> : BinaryStringExpression<TContext> where TContext : IContext
    {
        protected Concat(IStringExpression<TContext> lhs, IStringExpression<TContext> rhs) : base(lhs, rhs)
        {

        }

        public override string Interpret(TContext context)
        {
            return Lhs.Interpret(context) + Rhs.Interpret(context);
        }
    }
}