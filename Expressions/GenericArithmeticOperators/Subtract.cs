using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.GenericArithmeticOperators
{
    public class Subtract<TType, TContext> : BinaryExpression<TType, TContext>

    {
        public Subtract(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) : base(lhs,
            rhs)
        {
        }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 - dynamic2;
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is Add<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType, TContext> other)
        {
            return other is Subtract<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(Subtract<TType, TContext> lhs, Subtract<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(Subtract<TType, TContext> lhs, Subtract<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}