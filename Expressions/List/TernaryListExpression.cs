﻿using Aptacode.Expressions.Bool;

namespace Aptacode.Expressions.List
{
    public abstract class TernaryListExpression<TContext> : IListExpression<TContext> where TContext : IContext
    {
        protected TernaryListExpression(IBooleanExpression<TContext> condition,
            IListExpression<TContext> passExpression, IListExpression<TContext> failExpression)
        {
            Condition = condition;
            PassExpression = passExpression;
            FailExpression = failExpression;
        }

        public IBooleanExpression<TContext> Condition { get; }

        public IListExpression<TContext> PassExpression { get; }

        public IListExpression<TContext> FailExpression { get; }

        public abstract int[] Interpret(TContext context);
    }
}