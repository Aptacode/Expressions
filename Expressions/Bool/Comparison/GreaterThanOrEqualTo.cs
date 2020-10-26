﻿using Aptacode.Expressions.Integer;

namespace Aptacode.Expressions.Bool.Comparison
{
    public class GreaterThanOrEqualTo<TContext> : BinaryBoolComparison<TContext> where TContext : IContext
    {
        public GreaterThanOrEqualTo(IIntegerExpression<TContext> lhs, IIntegerExpression<TContext> rhs) :
            base(lhs, rhs) { }

        public override bool Interpret(TContext context) => Lhs.Interpret(context) >= Rhs.Interpret(context);
    }
}