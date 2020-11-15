namespace Aptacode.Expressions.Integer
{
    public interface IIntegerExpression<TContext> : IExpression<int, TContext>
    {
        new int Interpret(TContext context);
    }
}