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
    public class ExpressionVisitor<TContext> : IExpressionVisitor<TContext>
    {
        #region Integer

        public virtual void Schedule<TType>(INumericExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            switch (expression)
            {
                case BinaryNumericExpression<TType, TContext> binaryExpression:
                    Visit(binaryExpression);
                    break;
                case TernaryNumericExpression<TType, TContext> ternaryExpression:
                    Visit(ternaryExpression);
                    break;
                case ITerminalNumericExpression<TType, TContext> terminalExpression:
                    Visit(terminalExpression);
                    break;
                case UnaryListIntegerExpression<TType, TContext> listExpression:
                    Visit(listExpression);
                    break;
            }
        }

        public virtual void Visit<TType>(BinaryNumericExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit<TType>(TernaryNumericExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit<TType>(ITerminalNumericExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType> { }

        public virtual void Visit<TType>(UnaryNumericExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit<TType>(UnaryListIntegerExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Expression.Visit(this);
        }

        #endregion

        #region Bool

        public virtual void Schedule(IBooleanExpression<TContext> expression)
        {
            switch (expression)
            {
                case BinaryBoolExpression<TContext> binaryBoolExpression:
                    Visit(binaryBoolExpression);
                    break;
                case UnaryBoolExpression<TContext> unaryBoolExpression:
                    Visit(unaryBoolExpression);
                    break;
                case TerminalBoolExpression<TContext> terminalBoolExpression:
                    Visit(terminalBoolExpression);
                    break;
            }
        }

        public virtual void Visit(BinaryBoolExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(NaryBoolExpression<TContext> expression)
        {
            foreach (var innerExpression in expression.Expressions)
            {
                innerExpression.Visit(this);
            }
        }

        public virtual void Visit<TType>(BinaryBoolComparison<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(UnaryBoolExpression<TContext> expression)
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit(TerminalBoolExpression<TContext> expression) { }

        #endregion

        #region Color

        public virtual void Schedule(IColorExpression<TContext> expression)
        {
            switch (expression)
            {
                case BinaryColorExpression<TContext> binaryColorExpression:
                    Visit(binaryColorExpression);
                    break;
                case TernaryColorExpression<TContext> ternaryColorExpression:
                    Visit(ternaryColorExpression);
                    break;
                case TerminalColorExpression<TContext> terminalColorExpression:
                    Visit(terminalColorExpression);
                    break;
            }
        }

        public virtual void Visit(BinaryColorExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(TernaryColorExpression<TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit(TerminalColorExpression<TContext> expression) { }

        #endregion

        #region Guid

        public virtual void Schedule(IGuidExpression<TContext> expression)
        {
            switch (expression)
            {
                case BinaryGuidExpression<TContext> binaryGuidExpression:
                    Visit(binaryGuidExpression);
                    break;
                case TernaryGuidExpression<TContext> ternaryGuidExpression:
                    Visit(ternaryGuidExpression);
                    break;
                case TerminalGuidExpression<TContext> terminalGuidExpression:
                    Visit(terminalGuidExpression);
                    break;
            }
        }

        public virtual void Visit(BinaryGuidExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(TernaryGuidExpression<TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit(TerminalGuidExpression<TContext> expression) { }

        #endregion

        #region List

        public virtual void Schedule<TType>(IListExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            switch (expression)
            {
                case UnaryListExpression<TType, TContext> unaryListExpression:
                    Visit(unaryListExpression);
                    break;
                case BinaryListExpression<TType, TContext> binaryListExpression:
                    Visit(binaryListExpression);
                    break;
                case TernaryListExpression<TType, TContext> ternaryListExpression:
                    Visit(ternaryListExpression);
                    break;
                case TerminalListExpression<TType, TContext> terminalListExpression:
                    Visit(terminalListExpression);
                    break;
            }
        }

        public virtual void Visit<TType>(UnaryListExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit<TType>(BinaryListExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit<TType>(TernaryListExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit<TType>(TerminalListExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType> { }

        public void Visit<TType>(UnaryListItemExpression<TType, TContext> expression)
            where TType : struct, IConvertible, IEquatable<TType>
        {
            expression.Expression.Visit(this);
        }

        #endregion

        #region String

        public virtual void Schedule(IStringExpression<TContext> expression)
        {
            switch (expression)
            {
                case BinaryStringExpression<TContext> binaryStringExpression:
                    Visit(binaryStringExpression);
                    break;
                case TernaryStringExpression<TContext> ternaryStringExpression:
                    Visit(ternaryStringExpression);
                    break;
                case TerminalStringExpression<TContext> terminalStringExpression:
                    Visit(terminalStringExpression);
                    break;
            }
        }

        public virtual void Visit(BinaryStringExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(TernaryStringExpression<TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit(TerminalStringExpression<TContext> expression) { }

        #endregion
    }
}