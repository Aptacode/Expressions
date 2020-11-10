namespace Aptacode.Expressions.List
{
    public interface IListExpression<TContext> : IExpression<int[], TContext> where TContext : IContext
    {
        int[] Interpret(TContext context);
    }
}