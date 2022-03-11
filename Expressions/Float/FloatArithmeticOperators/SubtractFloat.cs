using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators;

public record SubtractFloat<TContext>
    (IExpression<float, TContext> Lhs, IExpression<float, TContext> Rhs) : Subtract<float, TContext>(Lhs, Rhs);