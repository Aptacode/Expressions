using System.Linq;

namespace Aptacode.Expressions.List
{
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