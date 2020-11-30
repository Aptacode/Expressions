using System.Collections.Generic;

namespace Aptacode.Expressions.Bool.RelationalOperators
{
    /// <summary>
    /// The class for the boolean relational operator '<c>&gt;=</c>' on expressions of a given type.
    /// </summary>
    /// <remarks>
    /// Expressions must be of the same type for relations to be defined on them. <br/>
    /// Care should be taken to ensure type comparison can be done on the given type.
    /// </remarks>
    public class GreaterThanOrEqualTo<TType, TContext> : BinaryBoolComparison<TType, TContext>

    {
        public GreaterThanOrEqualTo(IExpression<TType, TContext> lhs, IExpression<TType, TContext> rhs) :
            base(lhs, rhs) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns>True if lhs <c>&gt;=</c> rhs, otherwise false.</returns>
        public override bool Interpret(TContext context) =>
            Comparer<TType>.Default.Compare(Lhs.Interpret(context), Rhs.Interpret(context)) >= 0;
    }
}