using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.GenericArithmeticOperators
{
    public class Add<TType, TContext> : BinaryExpression<TType, TContext>

    {
        public Add(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) :
            base(lhs, rhs)
        {
        }

        public override TType Interpret(TContext context)
        {
            dynamic dynamic1 = Lhs.Interpret(context);
            dynamic dynamic2 = Rhs.Interpret(context);
            return dynamic1 + dynamic2;
        }


        #region IEquatable

        public override bool Equals(object obj) => obj is Add<TType, TContext> expression && Equals(expression);

        public override bool Equals(IExpression<TType, TContext> other) => other is Add<TType, TContext> expression && expression == this;

        public static bool operator ==(Add<TType, TContext> lhs, Add<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(Add<TType, TContext> lhs, Add<TType, TContext> rhs) => !(lhs == rhs);

        #endregion
    }
}