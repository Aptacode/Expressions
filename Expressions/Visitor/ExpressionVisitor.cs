using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions.Visitor
{
    public class ExpressionVisitor<TContext> : IExpressionVisitor<TContext> where TContext : IContext
    {
        #region Integer

        public virtual void Schedule(IIntegerExpression<TContext> expression)
        {
            switch (expression)
            {
                case BinaryIntegerExpression<TContext> binaryExpression:
                    Visit(binaryExpression);
                    break;
                case TernaryIntegerExpression<TContext> ternaryExpression:
                    Visit(ternaryExpression);
                    break;
                case TerminalIntegerExpression<TContext> terminalExpression:
                    Visit(terminalExpression);
                    break;
                case ListIntegerExpression<TContext> listExpression:
                    Visit(listExpression);
                    break;
            }
        }

        public virtual void Visit(BinaryIntegerExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(TernaryIntegerExpression<TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit(TerminalIntegerExpression<TContext> expression) { }

        public virtual void Visit(UnaryIntegerExpression<TContext> expression)
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit(ListIntegerExpression<TContext> expression)
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
                case BinaryBoolComparison<TContext> binaryBoolComparison:
                    Visit(binaryBoolComparison);
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

        public virtual void Visit(BinaryBoolComparison<TContext> expression)
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

        public virtual void Schedule(IListExpression<TContext> expression)
        {
            switch (expression)
            {
                case UnaryListExpression<TContext> unaryListExpression:
                    Visit(unaryListExpression);
                    break;
                case BinaryListExpression<TContext> binaryListExpression:
                    Visit(binaryListExpression);
                    break;
                case TernaryListExpression<TContext> ternaryListExpression:
                    Visit(ternaryListExpression);
                    break;
                case TerminalListExpression<TContext> terminalListExpression:
                    Visit(terminalListExpression);
                    break;
            }
        }

        public virtual void Visit(UnaryListExpression<TContext> expression)
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit(BinaryListExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit(TernaryListExpression<TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit(TerminalListExpression<TContext> expression) { }

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