namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of getting the first expression in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class First<TType, TContext> : UnaryListItemExpression<TType, TContext>

    {
        public First(IListExpression<TType, TContext> expression) : base(expression)
        {
        }

        public override TType Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length != 0 ? list[0] : default;
        }
    }
}