using System.Linq;
using Aptacode.Expressions.Utilities;

namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for the operation of getting the last m expressions in a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record TakeLast<TType, TContext>(IListExpression<TType, TContext> Expression,
    IExpression<int, TContext> CountExpression) : UnaryListExpression<TType, TContext>(Expression)

{
    public override TType[] Interpret(TContext context)
    {
        var list = Expression.Interpret(context);
        var count = CountExpression.Interpret(context);

        if (list.Length <= count)
        {
            return list;
        }

        return Expression.Interpret(context)
            .TakeLastItems(CountExpression.Interpret(context)).ToArray();
    }
}