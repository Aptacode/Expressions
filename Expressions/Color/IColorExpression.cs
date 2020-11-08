namespace Aptacode.Expressions.Color
{
    public interface IColorExpression<in TContext> where TContext : IContext
    {
        System.Drawing.Color Interpret(TContext context);
    }
}