using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators;

public record MultiplyDouble<TContext>
    (IExpression<double, TContext> Lhs, IExpression<double, TContext> Rhs) : Multiply<double, TContext>(Lhs, Rhs);