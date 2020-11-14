namespace Aptacode.Expressions.Integer
{
    public interface IIntegerExpression<TContext> : IExpression<int, TContext> where TContext : IContext
    {
        new int Interpret(TContext context);
    }
}