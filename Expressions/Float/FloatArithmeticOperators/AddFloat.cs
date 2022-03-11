using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators;

public record AddFloat<TContext>
    (IExpression<float, TContext> Lhs, IExpression<float, TContext> Rhs) : Add<float, TContext>(Lhs, Rhs);