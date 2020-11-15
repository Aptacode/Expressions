namespace Aptacode.Expressions.List
{
    public interface IListExpression<TContext> : IExpression<int[], TContext>
    {
        new int[] Interpret(TContext context);
    }
}