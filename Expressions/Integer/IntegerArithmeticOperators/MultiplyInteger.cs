using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Integer.IntegerArithmeticOperators;

public record MultiplyInteger<TContext>
    (IExpression<int, TContext> Lhs, IExpression<int, TContext> Rhs) : Multiply<int, TContext>(Lhs, Rhs);