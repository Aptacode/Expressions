namespace Aptacode.Expressions.Guid
{
    public interface IGuidExpression<TContext> : IExpression<System.Guid, TContext>
    {
        new System.Guid Interpret(TContext context);
    }
}