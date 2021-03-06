﻿namespace Aptacode.Expressions.List
{
    /// <summary>
    ///     The class for a conditional list expression of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConditionalListExpression<TType, TContext> : TernaryListExpression<bool, TType, TContext>

    {
        /// <summary>
        ///     Constructor to initialise a conditional list expression.
        /// </summary>
        /// <param name="condition">The boolean expression to be evaluated.</param>
        /// <param name="passExpression">The list expression returned on the condition evaluating to true.</param>
        /// <param name="failExpression">The list expression returned on the condition evaluating to false.</param>
        public ConditionalListExpression(IExpression<bool, TContext> condition,
            IListExpression<TType, TContext> passExpression, IListExpression<TType, TContext> failExpression) : base(condition,
            passExpression, failExpression)
        {
        }


        public override TType[] Interpret(TContext context)
        {
            return Condition.Interpret(context)
                ? PassExpression.Interpret(context)
                : FailExpression.Interpret(context);
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ConditionalListExpression<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType[], TContext> other)
        {
            return other is ConditionalListExpression<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(ConditionalListExpression<TType, TContext> lhs, ConditionalListExpression<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Condition.Equals(rhs.Condition) && lhs.PassExpression.Equals(rhs.PassExpression) && lhs.FailExpression.Equals(rhs.FailExpression);
        }

        public static bool operator !=(ConditionalListExpression<TType, TContext> lhs, ConditionalListExpression<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}