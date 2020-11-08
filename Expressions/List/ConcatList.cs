using System.Linq;

namespace Aptacode.Expressions.List
{
    public class ConcatList<TContext> : BinaryListExpression<TContext> where TContext : IContext
    {
        public ConcatList(IListExpression<TContext> lhs, IListExpression<TContext> rhs) : base(lhs, rhs) { }

        public override int[] Interpret(TContext context) =>
            Lhs.Interpret(context).Concat(Rhs.Interpret(context)).ToArray();
    }
}