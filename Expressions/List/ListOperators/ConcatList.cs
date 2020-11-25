using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    public class ConcatList<TType, TContext> : BinaryListExpression<TType, TContext>

    {
        public ConcatList(IListExpression<TType, TContext> lhs, IListExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }

        public override TType[] Interpret(TContext context) =>
            Lhs.Interpret(context).Concat(Rhs.Interpret(context)).ToArray();
    }
}