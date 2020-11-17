namespace Aptacode.Expressions.Double
{
    public interface IDoubleExpression<TContext> : IExpression<double, TContext>
    {
        new double Interpret(TContext context);
    }
}