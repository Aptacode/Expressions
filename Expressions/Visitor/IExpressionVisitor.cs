using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions.Visitor
{
    public interface IExpressionVisitor<T> where T : IContext
    {
        #region Integer

        void Visit(UnaryIntegerExpression<T> expression);
        void Visit(BinaryIntegerExpression<T> expression);
        void Visit(TernaryIntegerExpression<T> expression);
        void Visit(TerminalIntegerExpression<T> expression);
        void Visit(ListIntegerExpression<T> expression);

        #endregion

        #region Bool

        void Visit(BinaryBoolExpression<T> expression);
        void Visit(BinaryBoolComparison<T> expression);
        void Visit(UnaryBoolExpression<T> expression);
        void Visit(TerminalBoolExpression<T> expression);
        void Visit(NaryBoolExpression<T> expression);

        #endregion


        void Visit(BinaryColorExpression<T> expression);
        void Visit(TernaryColorExpression<T> expression);
        void Visit(TerminalColorExpression<T> expression);

        void Visit(BinaryGuidExpression<T> expression);
        void Visit(TernaryGuidExpression<T> expression);
        void Visit(TerminalGuidExpression<T> expression);

        void Visit(UnaryListExpression<T> expression);
        void Visit(BinaryListExpression<T> expression);
        void Visit(TernaryListExpression<T> expression);
        void Visit(TerminalListExpression<T> expression);

        void Visit(BinaryStringExpression<T> expression);
        void Visit(TernaryStringExpression<T> expression);
        void Visit(TerminalStringExpression<T> expression);
    }
}
