using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    ///     The class for operation of concatenating two list expressions.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConcatList<TType, TContext> : BinaryListExpression<TType, TContext>

    {
        public ConcatList(IListExpression<TType, TContext> lhs, IListExpression<TType, TContext> rhs) :
            base(lhs, rhs)
        {
        }

        public override TType[] Interpret(TContext context)
        {
            return Lhs.Interpret(context).Concat(Rhs.Interpret(context)).ToArray();
        }
    }
}