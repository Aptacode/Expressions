namespace Aptacode.Expressions.String
{
    public interface IStringExpression<in TContext> where TContext : IContext
    {
        string Interpret(TContext context);
    }
}