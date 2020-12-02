using System.Linq;

namespace Aptacode.Expressions.List.ListOperators
{
    /// <summary>
    /// The class for the operation of appending an expression to a list expression.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class Append<TType, TContext> : UnaryListExpression<TType, TContext>

    {
        public Append(IListExpression<TType, TContext> expression,
            IExpression<TType, TContext> elementExpression) :
            base(expression)
        {
            ElementExpression = elementExpression;
        }

        public IExpression<TType, TContext> ElementExpression { get; }

        public override TType[] Interpret(TContext context) => Expression.Interpret(context).Concat(Enumerable.Repeat(ElementExpression.Interpret(context), 1)).ToArray();
    }
}