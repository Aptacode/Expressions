namespace Aptacode.Expressions.String
{
    public interface IStringExpression<TContext> : IExpression<string, TContext>
    {
        new string Interpret(TContext context);
    }
}