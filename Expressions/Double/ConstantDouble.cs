using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Double;

public record ConstantDouble<TContext>(double Value) : ConstantExpression<double, TContext>(Value);