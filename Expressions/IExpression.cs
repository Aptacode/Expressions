using System;
using System.Collections.Generic;
using System.Text;
using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions
{
    public interface IExpression<TType, TContext> where TContext : IContext
    {
        TType Interpret(TContext context);
        void Visit(IExpressionVisitor<TContext> visitor);
    }
}
