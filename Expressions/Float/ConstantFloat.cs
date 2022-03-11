using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Float;

public record ConstantFloat<TContext>(float Value) : ConstantExpression<float, TContext>(Value);