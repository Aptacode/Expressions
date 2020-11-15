﻿namespace Aptacode.Expressions.List
{
    public class ConstantList<TContext> : TerminalListExpression<TContext> 
    {
        public ConstantList(int[] value)
        {
            Value = value;
        }

        public int[] Value { get; }

        public override int[] Interpret(TContext context) => Value;
    }
}