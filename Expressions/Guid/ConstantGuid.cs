using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Guid;

public record ConstantGuid<TContext>(System.Guid Value) : ConstantExpression<System.Guid, TContext>(Value);