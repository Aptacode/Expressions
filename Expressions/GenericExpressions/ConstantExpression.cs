using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.GenericExpressions
{
    /// <summary>
    ///     The class for a constant expression of any type.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class ConstantExpression<TType, TContext> : TerminalExpression<TType, TContext>
    {
        public readonly TType Value;

        /// <summary>
        ///     Constructor to initialise a constant expression.
        /// </summary>
        /// <param name="value">An object of any given type.</param>
        public ConstantExpression(TType value)
        {
            Value = value;
        }

        public override TType Interpret(TContext context)
        {
            return Value;
        }

        public new void Visit(IExpressionVisitor<TContext> visitor)
        {
            visitor.Visit(this);
        }
    }
}