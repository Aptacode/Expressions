﻿using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for the operation of getting the last expression in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class Last<TType, TContext> : UnaryListItemExpression<TType, TContext>

    {
        public Last(IListExpression<TType, TContext> expression) : base(expression)
        {
        }

        public override TType Interpret(TContext context)
        {
            var list = Expression.Interpret(context);
            return list.Length != 0 ? list.Last() : default;
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is Last<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType, TContext> other)
        {
            return other is Last<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(Last<TType, TContext> lhs, Last<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Expression.Equals(rhs.Expression);
        }

        public static bool operator !=(Last<TType, TContext> lhs, Last<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}