using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.RelationalOperators;

/// <summary>
///     The class for the boolean relational operator '<c>&lt;</c>' on expressions of a given type.
/// </summary>
/// <remarks>
///     Expressions must be of the same type for relations to be defined on them. <br />
///     Care should be taken to ensure type comparison can be done on the given type.
/// </remarks>
public record LessThan<TType, TContext>(IExpression<TType, TContext> Lhs, IExpression<TType, TContext> Rhs) :
    BinaryBoolComparison<TType, TContext>(Lhs,
        Rhs)

{
    /// <summary>
    /// </summary>
    /// <param name="context"></param>
    /// <returns>True if lhs <c>&lt;</c> rhs, otherwise false.</returns>
    public override bool Interpret(TContext context)
    {
        return Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) < 0;
    }
}