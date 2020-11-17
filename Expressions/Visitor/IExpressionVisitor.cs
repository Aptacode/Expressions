using System;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.List;
using Aptacode.Expressions.Numeric;
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

        void Visit<TType>(UnaryListExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(BinaryListExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(TernaryListExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(TerminalListExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(UnaryListItemExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(UnaryListIntegerExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        #endregion

        #region String

        void Visit(BinaryStringExpression<T> expression);
        void Visit(TernaryStringExpression<T> expression);
        void Visit(TerminalStringExpression<T> expression);

        #endregion

        #region Integer

        void Visit<TType>(UnaryNumericExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(BinaryNumericExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(TernaryNumericExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit<TType>(ITerminalNumericExpression<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        #endregion

        #region Bool

        void Visit(BinaryBoolExpression<T> expression);

        void Visit<TType>(BinaryBoolComparison<TType, T> expression)
            where TType : struct, IConvertible, IEquatable<TType>;

        void Visit(UnaryBoolExpression<T> expression);
        void Visit(TerminalBoolExpression<T> expression);
        void Visit(NaryBoolExpression<T> expression);

        #endregion
    }
}