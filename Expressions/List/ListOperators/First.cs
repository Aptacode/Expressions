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

        #region IEquatable

        public override bool Equals(object obj) => obj is First<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType, TContext> other) => other is First<TType, TContext> expression && expression == this;
        public static bool operator ==(First<TType, TContext> lhs, First<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression);
        }

        public static bool operator !=(First<TType, TContext> lhs, First<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}