using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.String;

public record ConstantString<TContext>(string Value) : ConstantExpression<string, TContext>(Value);