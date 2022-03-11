using Aptacode.Expressions.Visitor;

namespace Aptacode.Expressions;

/// <summary>
///     The base class for an expression.
/// </summary>
/// <typeparam name="TType">The object type of the expression.</typeparam>
/// <typeparam name="TContext">The context of the expression.</typeparam>
public interface IExpression<TType, TContext>
{
    /// <summary>
    ///     The method called on an expression to evaluate it.
    /// </summary>
    /// <param name="context">The context in which to evaluate the expression.</param>
    /// <returns></returns>
    TType Interpret(TContext context);

    void Visit(IExpressionVisitor<TContext> visitor);
}