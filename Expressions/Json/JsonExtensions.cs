using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.EqualityOperators;
using Aptacode.Expressions.Integer;
using Newtonsoft.Json;
using JsonSubTypes;
using Aptacode.Expressions.Bool.LogicalOperators;
using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Integer.IntegerArithmeticOperators;
using Aptacode.Expressions.Guid;

namespace Aptacode.Expressions.Json
{
    public static class ExpressionsJsonExtensions

    {
        public static JsonSubtypesConverterBuilder IntExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<int, T>>(nameof(IExpression<int, T>))
                .RegisterSubtype<ConstantInteger<T>>(nameof(ConstantInteger<T>))
                .RegisterSubtype<AddInteger<T>>(nameof(AddInteger<T>))
                .RegisterSubtype<MultiplyInteger<T>>(nameof(MultiplyInteger<T>))
                .RegisterSubtype<SubtractInteger<T>>(nameof(SubtractInteger<T>));
        }

        public static JsonSerializerSettings AddGuidExpressions<T>(this JsonSerializerSettings settings)
        {
            settings.Converters.Add(JsonSubtypesConverterBuilder
                .Of<IExpression<System.Guid, T>>(nameof(IExpression<System.Guid, T>))
                .RegisterSubtype<ConstantGuid<T>>(nameof(ConstantInteger<T>))
                .SerializeDiscriminatorProperty(true)
                .Build());

            return settings;
        }

        public static JsonSerializerSettings Add(this JsonSerializerSettings settings, JsonSubtypesConverterBuilder builder)
        {
            settings.Converters.Add(builder
                .SerializeDiscriminatorProperty(true)
                .Build());

            return settings;
        }

        public static JsonSubtypesConverterBuilder BoolExpressions<B>()
        {
            return JsonSubtypesConverterBuilder
                    .Of<IExpression<bool, B>>(nameof(IExpression<bool, B>))
                    .SerializeDiscriminatorProperty(true)
                    .RegisterSubtype<All<B>>(nameof(All<B>))
                    .RegisterSubtype<And<B>>(nameof(And<B>))
                    .RegisterSubtype<Any<B>>(nameof(Any<B>))
                    .RegisterSubtype<Not<B>>(nameof(Not<B>))
                    .RegisterSubtype<Or<B>>(nameof(Or<B>))
                    .RegisterSubtype<XOr<B>>(nameof(XOr<B>))
                    .RegisterSubtype<ConstantBool<B>>(nameof(ConstantBool<B>));
        }

        public static JsonSubtypesConverterBuilder AddBoolExpressions<A, B>(this JsonSubtypesConverterBuilder builder)
        {
            builder
                .RegisterSubtype<EqualTo<A, B>>(nameof(EqualTo<A, B>))
                .RegisterSubtype<NotEqualTo<A, B>>(nameof(NotEqualTo<A, B>))
                .RegisterSubtype<GreaterThan<A, B>>(nameof(GreaterThan<A, B>))
                .RegisterSubtype<GreaterThanOrEqualTo<A, B>>(nameof(GreaterThanOrEqualTo<A, B>))
                .RegisterSubtype<LessThanOrEqualTo<A, B>>(nameof(LessThanOrEqualTo<A, B>));

            return builder;
        }
    }
}
