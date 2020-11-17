namespace Aptacode.Expressions.Decimal
{
    public interface IDecimalExpression<TContext> : IExpression<decimal, TContext>
    {
        new decimal Interpret(TContext context);
    }
}