namespace Aptacode.Expressions.Bool
{
    public interface IBooleanExpression<in TContext> where TContext : IContext
    {
        bool Interpret(TContext context);
    }
}