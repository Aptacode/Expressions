﻿using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Integer
{
    public class AddInteger<TContext> : Add<int, TContext>
    {
        public AddInteger(IExpression<int, TContext> lhs, IExpression<int, TContext> rhs) : base(lhs, rhs) { }
    }
}