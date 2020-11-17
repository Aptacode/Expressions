namespace Aptacode.Expressions.List
{
    public class Count<TType, TContext> : UnaryListIntegerExpression<TType, TContext>

    {
        public Count(IListExpression<TType, TContext> expression) : base(expression) { }

        public override int Interpret(TContext context) => Expression.Interpret(context).Length;
    }
}