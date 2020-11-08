namespace Aptacode.Expressions.Guid
{
    public interface IGuidExpression<in TContext> where TContext : IContext
    {
        System.Guid Interpret(TContext context);
    }
}