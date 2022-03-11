using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.Decimal.DecimalArithmeticOperators;

public record AddDecimal<TContext>
    (IExpression<decimal, TContext> Lhs, IExpression<decimal, TContext> Rhs) : Add<decimal, TContext>(Lhs, Rhs);