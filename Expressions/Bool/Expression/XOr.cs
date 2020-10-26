﻿namespace Aptacode.Expressions.Bool.Expression
{
    public class XOr<TContext> : BinaryBoolExpression<TContext> where TContext : IContext
    {
        public override bool Interpret(TContext context) => Lhs.Interpret(context) ^ Rhs.Interpret(context);
        public XOr(IBooleanExpression<TContext> lhs, IBooleanExpression<TContext> rhs) : base(lhs, rhs) { }
    }
}