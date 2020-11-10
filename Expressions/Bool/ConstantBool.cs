using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions.Bool
{
    public class ConstantBool<TContext> : TerminalBoolExpression<TContext> where TContext : IContext
    {
        public ConstantBool(bool value)
        {
            Value = value;
        }

        public bool Value { get; }

        public override bool Interpret(TContext context) => Value;
    }
}