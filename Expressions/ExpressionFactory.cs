using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Bool.Expression;
using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions
{
    public class ExpressionFactory<TContext> where TContext : IContext
    {
        #region Integer Expressions

        public ConstantInteger<TContext> Int(int value) => new ConstantInteger<TContext>(value);

        public Add<TContext> Add(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new Add<TContext>(lhs, rhs);

        public Multiply<TContext> Multiply(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new Multiply<TContext>(lhs, rhs);

        public Subtract<TContext> Subtract(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new Subtract<TContext>(lhs, rhs);

        public Conditional<TContext> Conditional(IBooleanExpression<TContext> condition,
            IIntegerExpression<TContext> passExpression,
            IIntegerExpression<TContext> failExpression) =>
            new Conditional<TContext>(condition, passExpression, failExpression);

        #endregion

        #region Boolean Expressions

        public ConstantBool<TContext> Bool(bool value) => new ConstantBool<TContext>(value);

        public EqualTo<TContext> EqualTo(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new EqualTo<TContext>(lhs, rhs);

        public GreaterThan<TContext> GreaterThan(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new GreaterThan<TContext>(lhs, rhs);

        public GreaterThanOrEqualTo<TContext> GreaterThanOrEqualTo(IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) => new GreaterThanOrEqualTo<TContext>(lhs, rhs);

        public LessThan<TContext> LessThan(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) =>
            new LessThan<TContext>(lhs, rhs);

        public LessThanOrEqualTo<TContext> LessThanOrEqualTo(IIntegerExpression<TContext> lhs,
            IIntegerExpression<TContext> rhs) => new LessThanOrEqualTo<TContext>(lhs, rhs);

        public And<TContext> And(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) =>
            new And<TContext>(lhs, rhs);

        public Or<TContext> Or(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) =>
            new Or<TContext>(lhs, rhs);

        public Not<TContext> Not(IBooleanExpression<TContext> lhs) => new Not<TContext>(lhs);

        public XOr<TContext> XOr(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) =>
            new XOr<TContext>(lhs, rhs);

        #endregion
    }
}