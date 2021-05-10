namespace Aptacode.Expressions.List
{
    /// <summary>
    ///     The class for a constant list expression containing expressions of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConstantList<TType, TContext> : TerminalListExpression<TType, TContext>

    {
        public ConstantList(TType[] value)
        {
            Value = value;
        }

        public TType[] Value { get; }

        public override TType[] Interpret(TContext context)
        {
            return Value;
        }

        #region IEquatable

        public override bool Equals(object obj)
        {
            return obj is ConstantList<TType, TContext> expression && Equals(expression);
        }

        public override bool Equals(IExpression<TType[], TContext> other)
        {
            return other is ConstantList<TType, TContext> expression && expression == this;
        }

        public static bool operator ==(ConstantList<TType, TContext> lhs, ConstantList<TType, TContext> rhs)
        {
            if (lhs is null || rhs is null)
            {
                return lhs is null && rhs is null;
            }

            return lhs.Value.Equals(rhs.Value);
        }

        public static bool operator !=(ConstantList<TType, TContext> lhs, ConstantList<TType, TContext> rhs)
        {
            return !(lhs == rhs);
        }

        #endregion
    }
}