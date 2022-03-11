using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Integer;

public record ConstantInteger<TContext>(int Value) : ConstantExpression<int, TContext>(Value);