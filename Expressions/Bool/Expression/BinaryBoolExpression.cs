namespace Aptacode.Expressions.Bool.Expression
{
    public abstract class BinaryBoolExpression<TContext> : IBooleanExpression<TContext> where TContext : IContext
    {
        protected BinaryBoolExpression(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public IBooleanExpression<TContext> Lhs { get; }

        public IBooleanExpression<TContext> Rhs { get; }

        public abstract bool Interpret(TContext context);
    }
}