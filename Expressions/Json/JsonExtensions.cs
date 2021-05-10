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
using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Integer.IntegerArithmeticOperators;
using Aptacode.Expressions.List;
using Aptacode.Expressions.List.IntegerListOperators;
using Aptacode.Expressions.List.ListOperators;
using Aptacode.Expressions.String;
using Aptacode.Expressions.String.StringOperators;
using Newtonsoft.Json;

namespace Aptacode.Expressions.Json
{
    public static class ExpressionsJsonExtensions
    {
        public static JsonSerializerSettings Add(this JsonSerializerSettings settings, ExpressionsSubTypes subTypes)
        {
            return subTypes.AddSubTypes(settings);
        }

        public static ExpressionsSubTypes AddColor<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantColor<B>>();
        }

        public static ExpressionsSubTypes AddDecimal<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantDecimal<B>>()
                .Add<AddDecimal<B>>()
                .Add<MultiplyDecimal<B>>()
                .Add<SubtractDecimal<B>>();
        }

        public static ExpressionsSubTypes AddDouble<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantDouble<B>>()
                .Add<AddDouble<B>>()
                .Add<MultiplyDouble<B>>()
                .Add<SubtractDouble<B>>();
        }
        public static ExpressionsSubTypes AddFloat<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantFloat<B>>()
                .Add<AddFloat<B>>()
                .Add<MultiplyFloat<B>>()
                .Add<SubtractFloat<B>>();
        }

        public static ExpressionsSubTypes AddInt<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantInteger<B>>()
                .Add<AddInteger<B>>()
                .Add<MultiplyInteger<B>>()
                .Add<SubtractInteger<B>>();
        }

        public static ExpressionsSubTypes AddGuid<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantGuid<B>>();
        }

        public static ExpressionsSubTypes AddBool<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<All<B>>()
                .Add<And<B>>()
                .Add<Any<B>>()
                .Add<Not<B>>()
                .Add<Or<B>>()
                .Add<XOr<B>>()
                .Add<ConstantBool<B>>();
        }

        public static ExpressionsSubTypes AddList<A,B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes
                .Add<Append<A, B>>()
                .Add<ConcatList<A, B>>()
                .Add<ConditionalListExpression<A, B>>()
                .Add<ConstantList<A, B>>()
                .Add<Count<A, B>>()
                .Add<First<A, B>>()
                .Add<GetValue<A, B>>()
                .Add<Last<A, B>>()
                .Add<TakeFirst<A, B>>()
                .Add<TakeLast<A, B>>();
        }
        public static ExpressionsSubTypes AddString<B>(this ExpressionsSubTypes subTypes)
        {
            return subTypes.Add<ConstantString<B>>()
                .Add<ConcatString<B>>();
        }

        public static ExpressionsSubTypes AddBool<A, B>(this ExpressionsSubTypes subTypes)
        {
            subTypes
                .Add<ConditionalExpression<A, B>>()
                .Add<EqualTo<A, B>>()
                .Add<NotEqualTo<A, B>>()
                .Add<GreaterThan<A, B>>()
                .Add<GreaterThanOrEqualTo<A, B>>()
                .Add<LessThan<A, B>>()
                .Add<LessThanOrEqualTo<A, B>>();

            return subTypes;
        }
    }
}