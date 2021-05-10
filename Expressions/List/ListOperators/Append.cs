using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of appending an expression to a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class Append<TType, TContext> : UnaryListExpression<TType, TContext>

    {
        public Append(IListExpression<TType, TContext> expression,
            IExpression<TType, TContext> elementExpression) :
            base(expression)
        {
            ElementExpression = elementExpression;
        }

        public IExpression<TType, TContext> ElementExpression { get; }

        public override TType[] Interpret(TContext context)
        {
            return Expression.Interpret(context).Concat(Enumerable.Repeat(ElementExpression.Interpret(context), 1)).ToArray();
        }

        #region IEquatable

        public override bool Equals(object obj) => obj is Append<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType[], TContext> other) => other is Append<TType, TContext> expression && expression == this;

        public static bool operator ==(Append<TType, TContext> lhs, Append<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression) && lhs.ElementExpression.Equals(rhs.ElementExpression);
        }

        public static bool operator !=(Append<TType, TContext> lhs, Append<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}