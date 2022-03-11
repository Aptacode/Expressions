namespace Aptacode.Expressions.List.IntegerListOperators;

/// <summary>
///     The class for the operation of returning the number of expressions in a list expression.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record Count<TType, TContext>
    (IListExpression<TType, TContext> Expression) : UnaryListIntegerExpression<TType, TContext>(Expression)

{
    public override int Interpret(TContext context)
    {
        return Expression.Interpret(context).Length;
    }
}