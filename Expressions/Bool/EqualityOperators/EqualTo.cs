using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.EqualityOperators;

/// <summary>
///     The class for the boolean equality operator '<c>==</c>' on expressions of a given type.
/// </summary>
/// <remarks>Expressions must be of the same type for equality to be defined on them.</remarks>
public record EqualTo<TType, TContext>(IExpression<TType, TContext> Lhs, IExpression<TType, TContext> Rhs) :
    BinaryBoolComparison<TType, TContext>(Lhs,
        Rhs)

{
    public override bool Interpret(TContext context)
    {
        return Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) == 0;
    }
}