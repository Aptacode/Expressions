using Aptacode.Expressions.GenericExpressions;

namespace Aptacode.Expressions.GenericArithmeticOperators;

public record Add<TType, TContext>
    (IExpression<TType, TContext> Lhs, IExpression<TType, TContext> Rhs) : BinaryExpression<TType, TContext>(Lhs, Rhs)

{
    public override TType Interpret(TContext context)
    {
        dynamic dynamic1 = Lhs.Interpret(context);
        dynamic dynamic2 = Rhs.Interpret(context);
        return dynamic1 + dynamic2;
    }
}