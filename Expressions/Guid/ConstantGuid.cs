using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.Guid
{
    public class ConstantGuid<TContext> : ConstantExpression<System.Guid, TContext>
    {
        public ConstantGuid(System.Guid value) : base(value) { }
    }
}