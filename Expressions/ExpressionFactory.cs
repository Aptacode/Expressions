using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Bool.Expression;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Decimal;
using Aptacode.Expressions.Double;
using Aptacode.Expressions.Float;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Integer.List;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions
{
    public class ExpressionFactory<TContext> 
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

        #region Float Expressions
        public ConstantFloat<TContext> Float(float value) => new ConstantFloat<TContext>(value);

        public AddFloat<TContext> AddFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) =>
            new AddFloat<TContext>(lhs, rhs);

        public MultiplyFloat<TContext> MultiplyFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) =>
            new MultiplyFloat<TContext>(lhs, rhs);

        public SubtractFloat<TContext> SubtractFloat(IFloatExpression<TContext> lhs, IFloatExpression<TContext> rhs) =>
            new SubtractFloat<TContext>(lhs, rhs);

        public ConditionalFloat<TContext> Conditional(IBooleanExpression<TContext> condition,
            IFloatExpression<TContext> passExpression,
            IFloatExpression<TContext> failExpression) =>
            new ConditionalFloat<TContext>(condition, passExpression, failExpression);

        #endregion


        #region Double Expressions

        public ConstantDouble<TContext> Double(double value) => new ConstantDouble<TContext>(value);

        public AddDouble<TContext> AddDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) =>
            new AddDouble<TContext>(lhs, rhs);

        public MultiplyDouble<TContext> MultiplyFloat(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) =>
            new MultiplyDouble<TContext>(lhs, rhs);

        public SubtractDouble<TContext> SubtractDouble(IDoubleExpression<TContext> lhs, IDoubleExpression<TContext> rhs) =>
            new SubtractDouble<TContext>(lhs, rhs);

        public ConditionalDouble<TContext> ConditionalDouble(IBooleanExpression<TContext> condition,
            IDoubleExpression<TContext> passExpression,
            IDoubleExpression<TContext> failExpression) =>
            new ConditionalDouble<TContext>(condition, passExpression, failExpression);

        #endregion

        #region Decimal Expressions

        public ConstantDecimal<TContext> Decimal(decimal value) => new ConstantDecimal<TContext>(value);

        public AddDecimal<TContext> AddDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) =>
            new AddDecimal<TContext>(lhs, rhs);

        public MultiplyDecimal<TContext> MultiplyFloat(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) =>
            new MultiplyDecimal<TContext>(lhs, rhs);

        public SubtractDecimal<TContext> SubtractDecimal(IDecimalExpression<TContext> lhs, IDecimalExpression<TContext> rhs) =>
            new SubtractDecimal<TContext>(lhs, rhs);

        public ConditionalDecimal<TContext> ConditionalDecimal(IBooleanExpression<TContext> condition,
            IDecimalExpression<TContext> passExpression,
            IDecimalExpression<TContext> failExpression) =>
            new ConditionalDecimal<TContext>(condition, passExpression, failExpression);

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

        #region List Expressions

        public ConstantList<TContext> List(int[] value) => new ConstantList<TContext>(value);

        public ConcatList<TContext> Concat(IListExpression<TContext> lhs, IListExpression<TContext> rhs) =>
            new ConcatList<TContext>(lhs, rhs);

        public First<TContext> First(IListExpression<TContext> list) => new First<TContext>(list);
        public Count<TContext> Count(IListExpression<TContext> list) => new Count<TContext>(list);
        public Last<TContext> Last(IListExpression<TContext> list) => new Last<TContext>(list);

        public TakeFirst<TContext> TakeFirst(IListExpression<TContext> list, IIntegerExpression<TContext> count) =>
            new TakeFirst<TContext>(list, count);

        public TakeLast<TContext> TakeLast(IListExpression<TContext> list, IIntegerExpression<TContext> count) =>
            new TakeLast<TContext>(list, count);

        #endregion
    }
}