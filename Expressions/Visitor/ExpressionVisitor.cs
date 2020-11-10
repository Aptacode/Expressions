using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List;
using Aptacode.Expressions.String;

namespace Aptacode.Expressions.Visitor
{
    public class ExpressionVisitor<TContext> :IExpressionVisitor<TContext> where TContext : IContext
    {
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

        public virtual void Visit(TerminalIntegerExpression<TContext> expression)
        {
            
        }

        public virtual void Visit(ListIntegerExpression<TContext> expression)
        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit(BinaryBoolExpression<TContext> expression)
        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
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

        public virtual void Visit(TerminalBoolExpression<TContext> expression)
        {

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

        public virtual void Visit(TerminalColorExpression<TContext> expression)
        {

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

        public virtual void Visit(TerminalGuidExpression<TContext> expression)
        {

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

        public virtual void Visit(TerminalListExpression<TContext> expression)
        {

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

        public virtual void Visit(TerminalStringExpression<TContext> expression)
        {

        }
    }
}
