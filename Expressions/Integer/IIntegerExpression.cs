namespace Expressions.Integer
{
    public interface IIntegerExpression<in TContext> where TContext : IContext
    {
        int Interpret(TContext context);
    }
}