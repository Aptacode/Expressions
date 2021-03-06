﻿using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.RelationalOperators
{
    /// <summary>
    ///     The class for the boolean relational operator '<c>&lt;</c>' on expressions of a given type.
    /// </summary>
    /// <remarks>
    ///     Expressions must be of the same type for relations to be defined on them. <br />
    ///     Care should be taken to ensure type comparison can be done on the given type.
    /// </remarks>
    public class LessThan<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public LessThan(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns>True if lhs <c>&lt;</c> rhs, otherwise false.</returns>
        public override bool Interpret(TContext context)
        {
            return Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) < 0;
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is LessThan<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<bool, TContext> other)
        {
            return other is LessThan<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(LessThan<TType, TContext> lhs, LessThan<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(LessThan<TType, TContext> lhs, LessThan<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}