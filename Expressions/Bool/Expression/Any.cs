using System.Linq;

namespace Aptacode.Expressions.Bool.Expression
{
    public class Any<TContext> : NaryBoolExpression<TContext> where TContext : IContext
    {
        public Any(params IBooleanExpression<TContext>[] expressions) : base(expressions) { }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(false, (current, booleanExpression) => current || booleanExpression.Interpret(context));
        }
    }
}