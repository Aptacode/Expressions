namespace Aptacode.Expressions.String
{
    public interface IStringExpression<TContext> : IExpression<string, TContext> where TContext : IContext
    {
        string Interpret(TContext context);
    }
}