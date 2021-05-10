namespace Aptacode.Expressions.List.IntegerListOperators
{
    /// <summary>
    ///     The class for the operation of returning the number of expressions in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class Count<TType, TContext> : UnaryListIntegerExpression<TType, TContext>

    {
        public Count(IListExpression<TType, TContext> expression) : base(expression)
        {
        }

        public override int Interpret(TContext context)
        {
            return Expression.Interpret(context).Length;
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is Count<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<int, TContext> other) => other is Count<TType, TContext> expression && expression == this;
        public static bool operator ==(Count<TType, TContext> lhs, Count<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression);
        }

        public static bool operator !=(Count<TType, TContext> lhs, Count<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}