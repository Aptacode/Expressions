namespace Aptacode.Expressions.List.ListOperators;

/// <summary>
///     The class for the operation of getting an expression at a given index in a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record GetValue<TType, TContext>(IListExpression<TType, TContext> Expression,
    IExpression<int, TContext> IndexExpression) : UnaryListItemExpression<TType, TContext>(Expression)

{
    public override TType Interpret(TContext context)
    {
        var list = Expression.Interpret(context);
        var index = IndexExpression.Interpret(context);

        return list.Length <= index ? list[0] : Expression.Interpret(context)[IndexExpression.Interpret(context)];
    }
}