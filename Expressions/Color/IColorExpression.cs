namespace Aptacode.Expressions.Color
{
    public interface IColorExpression<TContext> : IExpression<System.Drawing.Color, TContext> where TContext : IContext
    {
        System.Drawing.Color Interpret(TContext context);
    }
}