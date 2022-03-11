namespace Aptacode.Expressions.List;

/// <summary>
///     The class for a constant list expression containing expressions of any type.
/// </summary>
/// <typeparam name="TType"></typeparam>
/// <typeparam name="TContext"></typeparam>
public record ConstantList<TType, TContext>(TType[] Value) : TerminalListExpression<TType, TContext>

{
    public override TType[] Interpret(TContext context)
    {
        return Value;
    }
}