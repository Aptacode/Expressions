using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Color;

public record ConstantColor<TContext>
    (System.Drawing.Color Value) : ConstantExpression<System.Drawing.Color, TContext>(Value);