using System;
using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Numeric
{
    public class ConditionalNumeric<TType, TContext> : TernaryNumericExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public ConditionalNumeric(IBooleanExpression<TContext> condition,
            INumericExpression<TType, TContext> passExpression,
            INumericExpression<TType, TContext> failExpression) : base(condition, passExpression, failExpression) { }

        public override TType Interpret(TContext context) => Condition.Interpret(context)
            ? PassExpression.Interpret(context)
            : FailExpression.Interpret(context);
    }
}