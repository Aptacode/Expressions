namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of getting an expression at a given index in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class GetValue<TType, TContext> : UnaryListItemExpression<TType, TContext>

    {
        public GetValue(IListExpression<TType, TContext> expression,
            IExpression<int, TContext> indexExpression) :
            base(expression)
        {
            IndexExpression = indexExpression;
        }

        public IExpression<int, TContext> IndexExpression { get; }

        public override TType Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            var index = IndexExpression.Interpret(context);

            return list.Length <= index ? list[0] : Expression.Interpret(context)[IndexExpression.Interpret(context)];
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is GetValue<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType, TContext> other)
        {
            return other is GetValue<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(GetValue<TType, TContext> lhs, GetValue<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression) && lhs.IndexExpression.Equals(rhs.IndexExpression);
        }

        public static bool operator !=(GetValue<TType, TContext> lhs, GetValue<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}