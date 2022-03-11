using System.Linq;

namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for the operation of appending an expression to a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record Append<TType, TContext>(IListExpression<TType, TContext> Expression,
    IExpression<TType, TContext> ElementExpression) : UnaryListExpression<TType, TContext>(Expression)

{
    public override TType[] Interpret(TContext context)
    {
        return Expression.Interpret(context).Concat(Enumerable.Repeat(ElementExpression.Interpret(context), 1))
            .ToArray();
    }
}