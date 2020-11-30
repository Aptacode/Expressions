using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Bool.LogicalOperators
{
    /// <summary>
    /// The class for the boolean conditional logical operator '<c>&&</c>' on boolean expressions.
    /// </summary>
    public class And<TContext> : BinaryExpression<bool, TContext>
    {
        public And(IExpression<bool, TContext> lhs, IExpression<bool, TContext> rhs) : base(lhs, rhs) { }
        public override bool Interpret(TContext context) => Lhs.Interpret(context) && Rhs.Interpret(context);
    }
}