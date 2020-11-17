namespace Aptacode.Expressions.Float
{
    public interface IFloatExpression<TContext> : IExpression<float, TContext>
    {
        new float Interpret(TContext context);
    }
}