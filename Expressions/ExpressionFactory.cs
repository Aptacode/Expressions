using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Bool.Expression;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.String;

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

        #region Color Expressions

        public ConstantColor<TContext> Color(System.Drawing.Color value) => new ConstantColor<TContext>(value);

        public ConditionalColor<TContext> Conditional(IBooleanExpression<TContext> condition,
            IColorExpression<TContext> passExpression,
            IColorExpression<TContext> failExpression) =>
            new ConditionalColor<TContext>(condition, passExpression, failExpression);

        #endregion

        #region String Expressions

        public ConstantString<TContext> String(string value) => new ConstantString<TContext>(value);

        public ConditionalString<TContext> Conditional(IBooleanExpression<TContext> condition,
            IStringExpression<TContext> passExpression,
            IStringExpression<TContext> failExpression) =>
            new ConditionalString<TContext>(condition, passExpression, failExpression);

        #endregion

        #region Guid Expressions

        public ConstantGuid<TContext> Color(System.Guid value) => new ConstantGuid<TContext>(value);

        public ConditionalGuid<TContext> Conditional(IBooleanExpression<TContext> condition,
            IGuidExpression<TContext> passExpression,
            IGuidExpression<TContext> failExpression) =>
            new ConditionalGuid<TContext>(condition, passExpression, failExpression);

        #endregion
    }
}