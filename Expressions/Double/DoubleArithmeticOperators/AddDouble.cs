using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Double.DoubleArithmeticOperators;

public record AddDouble<TContext>
    (IExpression<double, TContext> Lhs, IExpression<double, TContext> Rhs) : Add<double, TContext>(Lhs, Rhs);