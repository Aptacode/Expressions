namespace Aptacode.Expressions.String
{
    public interface IStringExpression<TContext> : IExpression<string, TContext> where TContext : IContext
    {
        new string Interpret(TContext context);
    }
}