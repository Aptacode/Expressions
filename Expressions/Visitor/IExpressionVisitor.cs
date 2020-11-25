using Aptacode.Expressions.Bool;
using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Visitor
{
    public interface IExpressionVisitor<T>
    {
        #region List

        void Visit<TType>(UnaryListExpression<TType, T> expression);

        void Visit<TType>(BinaryListExpression<TType, T> expression);

        void Visit<T1, T2>(TernaryListExpression<T1, T2, T> expression);

        void Visit<TType>(TerminalListExpression<TType, T> expression);

        void Visit<TType>(UnaryListItemExpression<TType, T> expression);

        void Visit<TType>(UnaryListIntegerExpression<TType, T> expression);

        #endregion

        #region Integer

        void Visit<TType>(UnaryExpression<TType, T> expression);

        void Visit<TType>(BinaryExpression<TType, T> expression);

        void Visit<TType>(ConditionalExpression<TType, T> expression);

        void Visit<TType>(TerminalExpression<TType, T> expression);

        void Visit<T1, T2>(TernaryExpression<T1, T2, T> expression);

        #endregion

        #region Bool

        void Visit<TType>(BinaryBoolComparison<TType, T> expression);

        void Visit(NaryBoolExpression<T> expression);

        #endregion
    }
}