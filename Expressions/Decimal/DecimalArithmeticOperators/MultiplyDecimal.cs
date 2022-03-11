using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Decimal.DecimalArithmeticOperators;

public record MultiplyDecimal<TContext>
    (IExpression<decimal, TContext> Lhs, IExpression<decimal, TContext> Rhs) : Multiply<decimal, TContext>(Lhs, Rhs);