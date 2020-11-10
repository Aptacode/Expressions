namespace Aptacode.Expressions.Guid
{
    public interface IGuidExpression<TContext> : IExpression<System.Guid, TContext> where TContext : IContext
    {
        System.Guid Interpret(TContext context);
    }
}