using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.EqualityOperators;
using Aptacode.Expressions.Integer;
using Newtonsoft.Json;
using JsonSubTypes;
using Aptacode.Expressions.Bool.LogicalOperators;
using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Integer.IntegerArithmeticOperators;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.List.IntegerListOperators;
using Aptacode.Expressions.List.ListOperators;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String.StringOperators;
using Aptacode.Expressions.String;

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
        public static JsonSubtypesConverterBuilder IntExpressions<T>()
        {
            return JsonSubtypesConverterBuilder.Of<IExpression<int, T>>(nameof(IExpression<int, T>))
                .RegisterSubtype<ConstantInteger<T>>(nameof(ConstantInteger<T>))
                .RegisterSubtype<AddInteger<T>>(nameof(AddInteger<T>))
                .RegisterSubtype<MultiplyInteger<T>>(nameof(MultiplyInteger<T>))
                .RegisterSubtype<SubtractInteger<T>>(nameof(SubtractInteger<T>));
        }

        public static JsonSubtypesConverterBuilder GuidExpressions<T>()
        {
            return JsonSubtypesConverterBuilder
               .Of<IExpression<System.Guid, T>>(nameof(IExpression<System.Guid, T>))
                    .SerializeDiscriminatorProperty(true)
                .RegisterSubtype<ConstantGuid<T>>(nameof(ConstantInteger<T>));       
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

        public static JsonSubtypesConverterBuilder ListExpressions<A, B>()
        {
            return JsonSubtypesConverterBuilder
                    .Of<IExpression<A[], B>>(nameof(IExpression<A[], B>))
                    .SerializeDiscriminatorProperty(true)
                    .RegisterSubtype<Count<A, B>>(nameof(Count<A, B>))
                    .RegisterSubtype<Append<A, B>>(nameof(Append<A, B>))
                    .RegisterSubtype<ConcatList<A, B>>(nameof(ConcatList<A, B>))
                    .RegisterSubtype<First<A, B>>(nameof(First<A, B>))
                    .RegisterSubtype<GetValue<A, B>>(nameof(GetValue<A, B>))
                    .RegisterSubtype<Last<A, B>>(nameof(Last<A, B>))
                    .RegisterSubtype<TakeFirst<A, B>>(nameof(TakeFirst<A, B>))
                    .RegisterSubtype<TakeLast<A, B>>(nameof(TakeLast<A, B>))
                    .RegisterSubtype<Count<A, B>>(nameof(Count<A, B>))
                    .RegisterSubtype<ConditionalListExpression<A, B>>(nameof(ConditionalListExpression<A, B>))
                    .RegisterSubtype<ConstantList<A, B>>(nameof(ConstantList<A, B>));
        }
        public static JsonSubtypesConverterBuilder StringExpressions<B>()
        {
            return JsonSubtypesConverterBuilder
                    .Of<IExpression<string, B>>(nameof(IExpression<string, B>))
                    .SerializeDiscriminatorProperty(true)
                    .RegisterSubtype<ConcatString<B>>(nameof(ConcatString<B>))
                    .RegisterSubtype<ConstantString<B>>(nameof(ConstantString<B>));
        }

        public static JsonSubtypesConverterBuilder ExtendBoolExpressions<A, B>(this JsonSubtypesConverterBuilder builder)
        {
            builder
                .RegisterSubtype<EqualTo<A, B>>(nameof(EqualTo<A, B>))
                .RegisterSubtype<NotEqualTo<A, B>>(nameof(NotEqualTo<A, B>))
                .RegisterSubtype<GreaterThan<A, B>>(nameof(GreaterThan<A, B>))
                .RegisterSubtype<GreaterThanOrEqualTo<A, B>>(nameof(GreaterThanOrEqualTo<A, B>))
                .RegisterSubtype<LessThan<A, B>>(nameof(LessThan<A, B>))
                .RegisterSubtype<LessThanOrEqualTo<A, B>>(nameof(LessThanOrEqualTo<A, B>));

            return builder;
        }
    }
}
