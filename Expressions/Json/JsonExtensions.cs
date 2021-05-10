using System.Linq;
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
using JsonSubTypes;
using Newtonsoft.Json;

namespace Aptacode.Expressions.Json
{
    public static class ExpressionsJsonExtensions

    {
        public static JsonSerializerSettings Add(this JsonSerializerSettings settings, JsonSubtypesConverterBuilder builder)
        {
            settings.Converters.Add(builder
                .SerializeDiscriminatorProperty(true)
                .Build());

            return settings;
        }

        public static JsonSubtypesConverterBuilder ColorExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<System.Drawing.Color, T>>(nameof(IExpression<System.Drawing.Color, T>))
                .Register<ConstantColor<T>>();
        }

        public static JsonSubtypesConverterBuilder DecimalExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<decimal, T>>(nameof(IExpression<decimal, T>))
                .Register<AddDecimal<T>>()
                .Register<MultiplyDecimal<T>>()
                .Register<SubtractDecimal<T>>()
                .Register<ConstantDecimal<T>>();
        }

        public static JsonSubtypesConverterBuilder DoubleExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<double, T>>(nameof(IExpression<double, T>))
                .Register<AddDouble<T>>()
                .Register<MultiplyDouble<T>>()
                .Register<SubtractDouble<T>>()
                .Register<ConstantDouble<T>>();
        }

        public static JsonSubtypesConverterBuilder FloatExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<float, T>>(nameof(IExpression<float, T>))
                .Register<AddFloat<T>>()
                .Register<MultiplyFloat<T>>()
                .Register<SubtractFloat<T>>()
                .Register<ConstantFloat<T>>();
        }

        public static JsonSubtypesConverterBuilder IntExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<int, T>>(nameof(IExpression<int, T>))
                .Register<ConstantInteger<T>>()
                .Register<AddInteger<T>>()
                .Register<MultiplyInteger<T>>()
                .Register<SubtractInteger<T>>();
        }

        public static JsonSubtypesConverterBuilder GuidExpressions<T>()
        {
            return JsonSubtypesConverterBuilder
                .Of<IExpression<System.Guid, T>>(nameof(IExpression<System.Guid, T>))
                .SerializeDiscriminatorProperty(true)
                .Register<ConstantGuid<T>>();
        }

        public static JsonSubtypesConverterBuilder BoolExpressions<B>()
        {
            return JsonSubtypesConverterBuilder
                .Of<IExpression<bool, B>>(nameof(IExpression<bool, B>))
                .SerializeDiscriminatorProperty(true)
                .Register<All<B>>()
                .Register<And<B>>()
                .Register<Any<B>>()
                .Register<Not<B>>()
                .Register<Or<B>>()
                .Register<XOr<B>>()
                .Register<ConstantBool<B>>();
        }

        public static JsonSubtypesConverterBuilder ListExpressions<A, B>()
        {
            return JsonSubtypesConverterBuilder
                .Of<IExpression<A[], B>>(nameof(IExpression<A[], B>))
                .SerializeDiscriminatorProperty(true)
                .Register<Append<A, B>>()
                .Register<ConcatList<A, B>>()
                .Register<ConditionalListExpression<A, B>>()
                .Register<ConstantList<A, B>>();
        }

        public static JsonSubtypesConverterBuilder ListOperations<A, B>(this JsonSubtypesConverterBuilder settings)
        {
            return settings
                .Register<Count<A, B>>()
                .Register<First<A, B>>()
                .Register<GetValue<A, B>>()
                .Register<Last<A, B>>()
                .Register<TakeFirst<A, B>>()
                .Register<TakeLast<A, B>>();
        }

        public static JsonSubtypesConverterBuilder StringExpressions<B>()
        {
            return JsonSubtypesConverterBuilder
                .Of<IExpression<string, B>>(nameof(IExpression<string, B>))
                .SerializeDiscriminatorProperty(true)
                .Register<ConcatString<B>>()
                .Register<ConstantString<B>>();
        }

        public static JsonSubtypesConverterBuilder ExtendBoolExpressions<A, B>(this JsonSubtypesConverterBuilder builder)
        {
            builder
                .Register<ConditionalExpression<A, B>>()
                .Register<EqualTo<A, B>>()
                .Register<NotEqualTo<A, B>>()
                .Register<GreaterThan<A, B>>()
                .Register<GreaterThanOrEqualTo<A, B>>()
                .Register<LessThan<A, B>>()
                .Register<LessThanOrEqualTo<A, B>>();

            return builder;
        }

        public static JsonSubtypesConverterBuilder Register<T>(this JsonSubtypesConverterBuilder builder)
        {
            return builder
                .RegisterSubtype<T>(GetName<T>());
        }

        public static string GetName<T>()
        {
            var type = typeof(T);
            var genericArguments = string.Join(",", type.GenericTypeArguments.Select(t => t.Name));
            return $"{type.Name}<{genericArguments}>";
        }
    }
}