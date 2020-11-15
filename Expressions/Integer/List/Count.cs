﻿using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Integer.List
{
    public class Count<TContext> : ListIntegerExpression<TContext> 
    {
        public Count(IListExpression<TContext> expression) : base(expression) { }

        public override int Interpret(TContext context) => Expression.Interpret(context).Length;
    }
}