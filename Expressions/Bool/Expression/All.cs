using System.Linq;

namespace Aptacode.Expressions.Bool.Expression
{
    public class All<TContext> : NaryBoolExpression<TContext>
    {
        public All(params IExpression<bool, TContext>[] expressions) : base(expressions) { }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(true,
                (current, booleanExpression) => current && booleanExpression.Interpret(context));
        }
    }
}