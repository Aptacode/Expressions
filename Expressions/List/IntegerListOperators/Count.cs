namespace Aptacode.Expressions.List.IntegerListOperators
{
    /// <summary>
    /// The class for the operation of returning the number of expressions in a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class Count<TType, TContext> : UnaryListIntegerExpression<TType, TContext>

    {
        public Count(IListExpression<TType, TContext> expression) : base(expression) { }

        public override int Interpret(TContext context) => Expression.Interpret(context).Length;
    }
}