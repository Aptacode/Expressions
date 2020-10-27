namespace Aptacode.Expressions.Bool.Expression
{
    public class Not<TContext> : UnaryBoolExpression<TContext> where TContext : IContext
    {
        public Not(IBooleanExpression<TContext> expression) : base(expression) { }
        public override bool Interpret(TContext context) => !Expression.Interpret(context);
    }
}