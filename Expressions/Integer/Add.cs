﻿namespace Aptacode.Expressions.Integer
{
    public class Add<TContext> : BinaryIntegerExpression<TContext> 
    {
        public Add(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) : base(lhs, rhs) { }

        public override int Interpret(TContext context) => Lhs.Interpret(context) + Rhs.Interpret(context);
    }
}