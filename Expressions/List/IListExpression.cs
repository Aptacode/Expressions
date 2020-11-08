namespace Aptacode.Expressions.List
{
    public interface IListExpression<in TContext> where TContext : IContext
    {
        int[] Interpret(TContext context);
    }
}