using System.Collections.Generic;
using System.Linq;

namespace Aptacode.Expressions.Bool.Expression
{
    public class All<TContext> : NaryBoolExpression<TContext> where TContext : IContext
    {
        public All(params IBooleanExpression<TContext>[] expressions) : base(expressions) { }

        public override bool Interpret(TContext context)
        {
            return Expressions.Aggregate(true, (current, booleanExpression) => current && booleanExpression.Interpret(context));
        }
    }
}