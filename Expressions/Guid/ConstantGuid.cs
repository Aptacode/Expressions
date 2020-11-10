using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.Guid
{
    public class ConstantGuid<TContext> : TerminalGuidExpression<TContext> where TContext : IContext
    {
        public ConstantGuid(System.Guid value)
        {
            Value = value;
        }

        public System.Guid Value { get; }

        public override System.Guid Interpret(TContext context) => Value;
    }
}