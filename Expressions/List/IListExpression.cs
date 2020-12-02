namespace Aptacode.Expressions.List
{
    /// <summary>
    /// The base class for a list expression, an expression that is a list of expressions.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public interface IListExpression<TType, TContext> : IExpression<TType[], TContext> { }
}