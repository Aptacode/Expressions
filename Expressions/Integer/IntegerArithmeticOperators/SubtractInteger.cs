using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators;

public record SubtractInteger<TContext>
    (IExpression<int, TContext> Lhs, IExpression<int, TContext> Rhs) : Subtract<int, TContext>(Lhs, Rhs);