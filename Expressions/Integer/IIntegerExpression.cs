namespace Aptacode.Expressions.Integer
{
    public interface IIntegerExpression<TContext> : IExpression<int, TContext> where TContext : IContext
    {
        int Interpret(TContext context);
    }
}