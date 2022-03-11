using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators;

public record AddInteger<TContext>
    (IExpression<int, TContext> Lhs, IExpression<int, TContext> Rhs) : Add<int, TContext>(Lhs, Rhs);