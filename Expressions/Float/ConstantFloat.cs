﻿using Aptacode.Expressions.Numeric;

namespace Aptacode.Expressions.Float
{
    public class ConstantFloat<TContext> : ConstantNumericExpression<float, TContext>
    {
        public ConstantFloat(float value) : base(value) { }
    }
}