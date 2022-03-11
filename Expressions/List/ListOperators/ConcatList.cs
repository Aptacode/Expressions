using System.Linq;

namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for operation of concatenating two list expressions.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record ConcatList<TType, TContext>
    (IListExpression<TType, TContext> Lhs, IListExpression<TType, TContext> Rhs) :
        BinaryListExpression<TType, TContext>(Lhs, Rhs)

{
    public override TType[] Interpret(TContext context)
    {
        return Lhs.Interpret(context).Concat(Rhs.Interpret(context)).ToArray();
    }
}