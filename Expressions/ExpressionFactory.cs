using System.Drawing;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.EqualityOperators;
using Aptacode.Expressions.Bool.LogicalOperators;
using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Decimal;
using Aptacode.Expressions.Decimal.DecimalArithmeticOperators;
using Aptacode.Expressions.Double;
using Aptacode.Expressions.Double.DoubleArithmeticOperators;
using Aptacode.Expressions.Float;
using Aptacode.Expressions.Float.FloatArithmeticOperators;
using Aptacode.Expressions.GenericArithmeticOperators;
using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Integer.IntegerArithmeticOperators;
using Aptacode.Expressions.List;
using Aptacode.Expressions.List.IntegerListOperators;
using Aptacode.Expressions.List.ListOperators;
using Aptacode.Expressions.String;
using Aptacode.Expressions.String.StringOperators;

namespace Aptacode.Expressions
{
    public class ExpressionFactory<TContext>
    {
        #region Constant Expressions

        public ConstantExpression<TType, TContext> Expression<TType>(TType value) => new ConstantExpression<TType, TContext>(value);
        public ConstantInteger<TContext> Int(int value) => new ConstantInteger<TContext>(value);
        public ConstantFloat<TContext> Float(float value) => new ConstantFloat<TContext>(value);
        public ConstantDouble<TContext> Double(double value) => new ConstantDouble<TContext>(value);
        public ConstantBool<TContext> Bool(bool value) => new ConstantBool<TContext>(value);
        public ConstantColor<TContext> Color(System.Drawing.Color value) => new ConstantColor<TContext>(value);
        public ConstantString<TContext> String(string value) => new ConstantString<TContext>(value);
        public ConstantGuid<TContext> Color(System.Guid value) => new ConstantGuid<TContext>(value);
        public ConstantList<TType, TContext> List<TType>(TType[] value) => new ConstantList<TType, TContext>(value);

        #endregion

        #region Conditional Expressions

        public ConditionalExpression<TType, TContext> Conditional<TType>(IExpression<bool, TContext> condition,
            IExpression<TType, TContext> passExpression,
            IExpression<TType, TContext> failExpression) =>
            new ConditionalExpression<TType, TContext>(condition, passExpression, failExpression);

        public IExpression<int, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<int, TContext> passExpression,
            IExpression<int, TContext> failExpression) =>
            new ConditionalExpression<int, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<float, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<float, TContext> passExpression,
            IExpression<float, TContext> failExpression) =>
            new ConditionalExpression<float, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<double, TContext> ConditionalDouble(IExpression<bool, TContext> condition,
            IExpression<double, TContext> passExpression,
            IExpression<double, TContext> failExpression) =>
            new ConditionalExpression<double, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<decimal, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<decimal, TContext> passExpression,
            IExpression<decimal, TContext> failExpression) =>
            new ConditionalExpression<decimal, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<System.Drawing.Color, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<System.Drawing.Color, TContext> passExpression,
            IExpression<System.Drawing.Color, TContext> failExpression) =>
            new ConditionalExpression<System.Drawing.Color, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<string, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<string, TContext> passExpression,
            IExpression<string, TContext> failExpression) =>
            new ConditionalExpression<string, TContext>(condition, passExpression, failExpression);

        public ConditionalExpression<System.Guid, TContext> Conditional(IExpression<bool, TContext> condition,
            IExpression<System.Guid, TContext> passExpression,
            IExpression<System.Guid, TContext> failExpression) =>
            new ConditionalExpression<System.Guid, TContext>(condition, passExpression, failExpression);

        public ConditionalListExpression<TType, TContext> ConditionalList<TType>(IExpression<bool, TContext> condition,
            IListExpression<TType, TContext> passExpression, 
            IListExpression<TType, TContext> failExpression) =>
            new ConditionalListExpression<TType, TContext>(condition, passExpression, failExpression);
        
        #endregion

        #region Arithmetic Operators

        #region Generic

        public Add<TType, TContext> Add<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new Add<TType, TContext>(lhs, rhs);

        public Multiply<TType, TContext> Multiply<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new Multiply<TType, TContext>(lhs, rhs);

        public Subtract<TType, TContext> Subtract<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new Subtract<TType, TContext>(lhs, rhs);

        #endregion

        #region Integer

        public AddInteger<TContext> AddInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) =>
            new AddInteger<TContext>(lhs, rhs);

        public MultiplyInteger<TContext> MultiplyInteger(IExpression<int, TContext> lhs,
            IExpression<int, TContext> rhs) =>
            new MultiplyInteger<TContext>(lhs, rhs);

        public SubtractInteger<TContext> SubtractInteger(IExpression<int, TContext> lhs,
            IExpression<int, TContext> rhs) =>
            new SubtractInteger<TContext>(lhs, rhs);

        #endregion

        #region Float

        public AddFloat<TContext> AddFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new AddFloat<TContext>(lhs, rhs);

        public MultiplyFloat<TContext>
            MultiplyFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new MultiplyFloat<TContext>(lhs, rhs);

        public SubtractFloat<TContext>
            SubtractFloat(IExpression<float, TContext> lhs, IExpression<float, TContext> rhs) =>
            new SubtractFloat<TContext>(lhs, rhs);

        #endregion

        #region Double

        public AddDouble<TContext> AddDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new AddDouble<TContext>(lhs, rhs);

        public MultiplyDouble<TContext>
            MultiplyFloat(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new MultiplyDouble<TContext>(lhs, rhs);

        public SubtractDouble<TContext>
            SubtractDouble(IExpression<double, TContext> lhs, IExpression<double, TContext> rhs) =>
            new SubtractDouble<TContext>(lhs, rhs);

        #endregion

        #region Decimal

        public AddDecimal<TContext> AddDecimal(IExpression<decimal, TContext> lhs, 
            IExpression<decimal, TContext> rhs) =>
            new AddDecimal<TContext>(lhs, rhs);

        public MultiplyDecimal<TContext> MultiplyFloat(IExpression<decimal, TContext> lhs,
            IExpression<decimal, TContext> rhs) =>
            new MultiplyDecimal<TContext>(lhs, rhs);

        public SubtractDecimal<TContext> SubtractDecimal(IExpression<decimal, TContext> lhs,
            IExpression<decimal, TContext> rhs) =>
            new SubtractDecimal<TContext>(lhs, rhs);


        #endregion

        #region String

        public ConcatString<TContext> Concat(IExpression<string, TContext> lhs,
            IExpression<string, TContext> rhs) =>
            new ConcatString<TContext>(lhs, rhs);

        #endregion

        #endregion

        #region Logical Operators

        public And<TContext> And(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new And<TContext>(lhs, rhs);

        public Or<TContext> Or(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new Or<TContext>(lhs, rhs);

        public Not<TContext> Not(IExpression<bool, TContext> lhs) => new Not<TContext>(lhs);

        public XOr<TContext> XOr(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) =>
            new XOr<TContext>(lhs, rhs);

        #endregion

        #region Relational Operators

        public GreaterThan<TType, TContext> GreaterThan<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new GreaterThan<TType, TContext>(lhs, rhs);

        public GreaterThanOrEqualTo<TType, TContext> GreaterThanOrEqualTo<TType>(
            IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new GreaterThanOrEqualTo<TType, TContext>(lhs, rhs);

        public LessThan<TType, TContext> LessThan<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new LessThan<TType, TContext>(lhs, rhs);

        public LessThanOrEqualTo<TType, TContext> LessThanOrEqualTo<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new LessThanOrEqualTo<TType, TContext>(lhs, rhs);

        #endregion

        #region Equality Operators

        public EqualTo<TType, TContext> EqualTo<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new EqualTo<TType, TContext>(lhs, rhs);

        public NotEqualTo<TType, TContext> NotEqualTo<TType>(IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new NotEqualTo<TType, TContext>(lhs, rhs);

        #endregion

        #region List Operators

        public ConcatList<TType, TContext> Concat<TType>(IListExpression<TType, TContext> lhs,
            IListExpression<TType, TContext> rhs) =>
            new ConcatList<TType, TContext>(lhs, rhs);

        public First<TType, TContext> First<TType>(IListExpression<TType, TContext> list)
            => new First<TType, TContext>(list);

        public Count<TType, TContext> Count<TType>(IListExpression<TType, TContext> list)
            => new Count<TType, TContext>(list);

        public Last<TType, TContext> Last<TType>(IListExpression<TType, TContext> list)
            => new Last<TType, TContext>(list);

        public TakeFirst<TType, TContext> TakeFirst<TType>(IListExpression<TType, TContext> list,
            IExpression<int, TContext> count) =>
            new TakeFirst<TType, TContext>(list, count);

        public TakeLast<TType, TContext> TakeLast<TType>(IListExpression<TType, TContext> list,
            IExpression<int, TContext> count) =>
            new TakeLast<TType, TContext>(list, count);

        public Append<TType, TContext> Append<TType>(IListExpression<TType, TContext> list,
            IExpression<TType, TContext> element) =>
            new Append<TType, TContext>(list, element);

        #endregion
    }
}