using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Decimal;
using Aptacode.Expressions.Double;
using Aptacode.Expressions.Float;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions.Visitor
{
    public interface IExpressionVisitor<T>
    {
        #region Color

        void Visit(BinaryColorExpression<T> expression);
        void Visit(TernaryColorExpression<T> expression);
        void Visit(TerminalColorExpression<T> expression);

        #endregion

        #region Guid

        void Visit(BinaryGuidExpression<T> expression);
        void Visit(TernaryGuidExpression<T> expression);
        void Visit(TerminalGuidExpression<T> expression);

        #endregion

        #region List

        void Visit(UnaryListExpression<T> expression);
        void Visit(BinaryListExpression<T> expression);
        void Visit(TernaryListExpression<T> expression);
        void Visit(TerminalListExpression<T> expression);

        #endregion

        #region String

        void Visit(BinaryStringExpression<T> expression);
        void Visit(TernaryStringExpression<T> expression);
        void Visit(TerminalStringExpression<T> expression);

        #endregion

        #region Integer

        void Visit(UnaryIntegerExpression<T> expression);
        void Visit(BinaryIntegerExpression<T> expression);
        void Visit(TernaryIntegerExpression<T> expression);
        void Visit(TerminalIntegerExpression<T> expression);
        void Visit(ListIntegerExpression<T> expression);

        #endregion

        #region Float

        void Visit(UnaryFloatExpression<T> expression);
        void Visit(BinaryFloatExpression<T> expression);
        void Visit(TernaryFloatExpression<T> expression);
        void Visit(TerminalFloatExpression<T> expression);

        #endregion

        #region Double

        void Visit(UnaryDoubleExpression<T> expression);
        void Visit(BinaryDoubleExpression<T> expression);
        void Visit(TernaryDoubleExpression<T> expression);
        void Visit(TerminalDoubleExpression<T> expression);

        #endregion
        
        #region Decimal

        void Visit(UnaryDecimalExpression<T> expression);
        void Visit(BinaryDecimalExpression<T> expression);
        void Visit(TernaryDecimalExpression<T> expression);
        void Visit(TerminalDecimalExpression<T> expression);

        #endregion

        #region Bool

        void Visit(BinaryBoolExpression<T> expression);
        void Visit(BinaryBoolComparison<T> expression);
        void Visit(UnaryBoolExpression<T> expression);
        void Visit(TerminalBoolExpression<T> expression);
        void Visit(NaryBoolExpression<T> expression);

        #endregion
    }
}