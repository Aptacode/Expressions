using Aptacode.Expressions.GenericArithmeticOperators;

namespace Aptacode.Expressions.String.StringOperators;

public record ConcatString<TContext>
    (IExpression<string, TContext> Lhs, IExpression<string, TContext> Rhs) : Add<string, TContext>(Lhs, Rhs);