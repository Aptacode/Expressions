using System.Linq;

namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for the operation of getting the first n expressions in a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record TakeFirst<TType, TContext>(IListExpression<TType, TContext> Expression,
    IExpression<int, TContext> CountExpression) : UnaryListExpression<TType, TContext>(Expression)

{
    public override TType[] Interpret(TContext context)
    {
        var list = Expression.Interpret(context);
        var count = CountExpression.Interpret(context);

        return list.Length <= count
            ? list
            : Expression.Interpret(context).Take(CountExpression.Interpret(context)).ToArray();
    }
}