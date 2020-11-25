namespace Aptacode.Expressions.Bool.EqualityOperators.Extensions
{
    public static class EqualityOperatorExtensions
    {
        public static EqualTo<TType, TContext> EqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new EqualTo<TType, TContext>(lhs, rhs);
        
        public static NotEqualTo<TType, TContext> NotEqualTo<TType, TContext>(
            this IExpression<TType, TContext> lhs,
            IExpression<TType, TContext> rhs) =>
            new NotEqualTo<TType, TContext>(lhs, rhs);
    }
}