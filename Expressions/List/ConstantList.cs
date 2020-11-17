using System;

namespace Aptacode.Expressions.List
{
    public class ConstantList<TType, TContext> : TerminalListExpression<TType, TContext>
        where TType : struct, IConvertible, IEquatable<TType>
    {
        public ConstantList(TType[] value)
        {
            Value = value;
        }

        public TType[] Value { get; }

        public override TType[] Interpret(TContext context) => Value;
    }
}