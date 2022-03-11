using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators;

public record SubtractDouble<TContext>
    (IExpression<double, TContext> Lhs, IExpression<double, TContext> Rhs) : Subtract<double, TContext>(Lhs, Rhs);