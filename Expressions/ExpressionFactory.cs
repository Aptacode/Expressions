using System;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Bool.Expression;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Decimal;
using Aptacode.Expressions.Double;
using Aptacode.Expressions.Float;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.Numeric;
using Aptacode.Expressions.Numeric.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions
{
    public class ExpressionFactory<TContext>
    {
        #region Numeric

        public Add<TType, TContext> Add<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new Add<TType, TContext>(lhs, rhs);

        public Multiply<TType, TContext> Multiply<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new Multiply<TType, TContext>(lhs, rhs);

        public Subtract<TType, TContext> Subtract<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new Subtract<TType, TContext>(lhs, rhs);

        public ConditionalNumeric<TType, TContext> Conditional<TType>(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression,
            IExpression<TType, TContext> failExpression) where TType : struct, IConvertible, IEquatable<TType> =>
            new ConditionalNumeric<TType, TContext>(condition, passExpression, failExpression);

        #endregion

        #region Integer Expressions

        public ConstantInteger<TContext> Int(int value) => new ConstantInteger<TContext>(value);

        public AddInteger<TContext> AddInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) =>
            new AddInteger<TContext>(lhs, rhs);

        public MultiplyInteger<TContext> MultiplyInteger(IExpression<int, TContext> lhs,
            IExpression<int, TContext> rhs) =>
            new MultiplyInteger<TContext>(lhs, rhs);

        public SubtractInteger<TContext> SubtractInteger(IExpression<int, TContext> lhs,
            IExpression<int, TContext> rhs) =>
            new SubtractInteger<TContext>(lhs, rhs);

        public ConditionalNumeric<int, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<int, TContext> passExpression,
            IExpression<int, TContext> failExpression) =>
            new ConditionalNumeric<int, TContext>(condition, passExpression, failExpression);

        #endregion

        #region Float Expressions

        public ConstantFloat<TContext> Float(float value) => new ConstantFloat<TContext>(value);

        public AddFloat<TContext> AddFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new AddFloat<TContext>(lhs, rhs);

        public MultiplyFloat<TContext> MultiplyFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new MultiplyFloat<TContext>(lhs, rhs);

        public SubtractFloat<TContext> SubtractFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new SubtractFloat<TContext>(lhs, rhs);

        public ConditionalNumeric<float, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<float, TContext> passExpression,
            IExpression<float, TContext> failExpression) =>
            new ConditionalNumeric<float, TContext>(condition, passExpression, failExpression);

        #endregion


        #region Double Expressions

        public ConstantDouble<TContext> Double(double value) => new ConstantDouble<TContext>(value);

        public AddDouble<TContext> AddDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new AddDouble<TContext>(lhs, rhs);

        public MultiplyDouble<TContext>
            MultiplyFloat(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new MultiplyDouble<TContext>(lhs, rhs);

        public SubtractDouble<TContext>
            SubtractDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new SubtractDouble<TContext>(lhs, rhs);

        public ConditionalNumeric<double, TContext> ConditionalDouble(IExpression<bool, TContext> condition,
            IExpression<double, TContext> passExpression,
            IExpression<double, TContext> failExpression) =>
            new ConditionalNumeric<double, TContext>(condition, passExpression, failExpression);

        #endregion

        #region Decimal Expressions

        public ConstantDecimal<TContext> Decimal(decimal value) => new ConstantDecimal<TContext>(value);

        public AddDecimal<TContext> AddDecimal(IExpression<decimal, TContext> lhs, IExpression<decimal, TContext> rhs) =>
            new AddDecimal<TContext>(lhs, rhs);

        public MultiplyDecimal<TContext> MultiplyFloat(IExpression<decimal, TContext> lhs,
            IExpression<decimal, TContext> rhs) =>
            new MultiplyDecimal<TContext>(lhs, rhs);

        public SubtractDecimal<TContext> SubtractDecimal(IExpression<decimal, TContext> lhs,
            IExpression<decimal, TContext> rhs) =>
            new SubtractDecimal<TContext>(lhs, rhs);

        public ConditionalNumeric<decimal, TContext> ConditionalDecimal(IExpression<bool, TContext> condition,
            IExpression<decimal, TContext> passExpression,
            IExpression<decimal, TContext> failExpression) =>
            new ConditionalNumeric<decimal, TContext>(condition, passExpression, failExpression);

        #endregion

        #region Boolean Expressions

        public ConstantBool<TContext> Bool(bool value) => new ConstantBool<TContext>(value);

        public EqualTo<TType, TContext> EqualTo<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new EqualTo<TType, TContext>(lhs, rhs);

        public GreaterThan<TType, TContext> GreaterThan<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThan<TType, TContext>(lhs, rhs);

        public GreaterThanOrEqualTo<TType, TContext> GreaterThanOrEqualTo<TType>(
            IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);

        public LessThan<TType, TContext> LessThan<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThan<TType, TContext>(lhs, rhs);

        public LessThanOrEqualTo<TType, TContext> LessThanOrEqualTo<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new LessThanOrEqualTo<TType, TContext>(lhs, rhs);

        public And<TContext> And(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new And<TContext>(lhs, rhs);

        public Or<TContext> Or(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new Or<TContext>(lhs, rhs);

        public Not<TContext> Not(IExpression<bool, TContext> lhs) => new Not<TContext>(lhs);

        public XOr<TContext> XOr(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new XOr<TContext>(lhs, rhs);

        #endregion

        #region Color Expressions

        public ConstantColor<TContext> Color(System.Drawing.Color value) => new ConstantColor<TContext>(value);

        public ConditionalColor<TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<System.Drawing.Color, TContext> passExpression,
            IExpression<System.Drawing.Color, TContext> failExpression) =>
            new ConditionalColor<TContext>(condition, passExpression, failExpression);

        #endregion

        #region String Expressions

        public ConstantString<TContext> String(string value) => new ConstantString<TContext>(value);

        public ConditionalString<TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<string, TContext> passExpression,
            IExpression<string, TContext> failExpression) =>
            new ConditionalString<TContext>(condition, passExpression, failExpression);

        #endregion

        #region Guid Expressions

        public ConstantGuid<TContext> Color(System.Guid value) => new ConstantGuid<TContext>(value);

        public ConditionalGuid<TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<System.Guid, TContext> passExpression,
            IExpression<System.Guid, TContext> failExpression) =>
            new ConditionalGuid<TContext>(condition, passExpression, failExpression);

        #endregion

        #region List Expressions

        public ConstantList<TType, TContext> List<TType>(TType[] value)
            where TType : struct, IConvertible, IEquatable<TType> => new ConstantList<TType, TContext>(value);

        public ConcatList<TType, TContext> Concat<TType>(IListExpression<TType, TContext> lhs,
            IListExpression<TType, TContext> rhs) where TType : struct, IConvertible, IEquatable<TType> =>
            new ConcatList<TType, TContext>(lhs, rhs);

        public First<TType, TContext> First<TType>(IListExpression<TType, TContext> list)
            where TType : struct, IConvertible, IEquatable<TType> => new First<TType, TContext>(list);

        public Count<TType, TContext> Count<TType>(IListExpression<TType, TContext> list)
            where TType : struct, IConvertible, IEquatable<TType> => new Count<TType, TContext>(list);

        public Last<TType, TContext> Last<TType>(IListExpression<TType, TContext> list)
            where TType : struct, IConvertible, IEquatable<TType> => new Last<TType, TContext>(list);

        public TakeFirst<TType, TContext> TakeFirst<TType>(IListExpression<TType, TContext> list,
            IExpression<int, TContext> count) where TType : struct, IConvertible, IEquatable<TType> =>
            new TakeFirst<TType, TContext>(list, count);

        public TakeLast<TType, TContext> TakeLast<TType>(IListExpression<TType, TContext> list,
            IExpression<int, TContext> count) where TType : struct, IConvertible, IEquatable<TType> =>
            new TakeLast<TType, TContext>(list, count);

        #endregion
    }
}