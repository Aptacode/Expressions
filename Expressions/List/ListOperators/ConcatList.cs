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


        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ConcatList<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType[], TContext> other)
        {
            return other is ConcatList<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(ConcatList<TType, TContext> lhs, ConcatList<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Lhs.Equals(rhs.Lhs) && lhs.Rhs.Equals(rhs.Rhs);
        }

        public static bool operator !=(ConcatList<TType, TContext> lhs, ConcatList<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}