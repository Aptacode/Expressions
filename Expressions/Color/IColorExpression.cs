namespace Aptacode.Expressions.Color
{
    public interface IColorExpression<TContext> : IExpression<System.Drawing.Color, TContext>
    {
        new System.Drawing.Color Interpret(TContext context);
    }
}