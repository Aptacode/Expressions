using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Decimal;

public record ConstantDecimal<TContext>(decimal Value) : ConstantExpression<decimal, TContext>(Value);