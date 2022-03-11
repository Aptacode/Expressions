using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Float.FloatArithmeticOperators;

public record MultiplyFloat<TContext>
    (IExpression<float, TContext> Lhs, IExpression<float, TContext> Rhs) : Multiply<float, TContext>(Lhs, Rhs);