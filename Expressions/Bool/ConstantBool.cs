using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool;

public record ConstantBool<TContext>(bool Value) : ConstantExpression<bool, TContext>(Value);