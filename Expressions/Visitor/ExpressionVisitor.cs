using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.List;

namespace Aptacode.Expressions.Visitor
{
    public class ExpressionVisitor<TContext> : IExpressionVisitor<TContext>
    {
        #region Integer

        public virtual void Schedule<TType>(IExpression<TType, TContext> expression)

        {
            switch (expression)
            {
                case BinaryExpression<TType, TContext> binaryExpression:
                    Visit(binaryExpression);
                    break;
                case ConditionalExpression<TType, TContext> ternaryExpression:
                    Visit(ternaryExpression);
                    break;
                case TerminalExpression<TType, TContext> terminalExpression:
                    Visit(terminalExpression);
                    break;
                case UnaryListIntegerExpression<TType, TContext> listExpression:
                    Visit(listExpression);
                    break;
            }
        }

        public virtual void Visit<TType>(BinaryExpression<TType, TContext> expression)

        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit<TType>(ConditionalExpression<TType, TContext> expression)

        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit<TType>(TerminalExpression<TType, TContext> expression) { }

        public void Visit<T1, T2>(TernaryExpression<T1, T2, TContext> expression)
        {
            expression.Condition.Visit(this);
            expression.PassExpression.Visit(this);
            expression.FailExpression.Visit(this);
        }

        public virtual void Visit<TType>(UnaryExpression<TType, TContext> expression)

        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit<TType>(UnaryListIntegerExpression<TType, TContext> expression)

        {
            expression.Expression.Visit(this);
        }

        #endregion

        #region Bool

        public virtual void Schedule(IExpression<bool, TContext> expression)
        {
            switch (expression)
            {
                case NaryBoolExpression<TContext> naryBoolExpression:
                    Visit(naryBoolExpression);
                    break;
            }
        }

        public virtual void Visit(NaryBoolExpression<TContext> expression)
        {
            foreach (var innerExpression in expression.Expressions)
            {
                innerExpression.Visit(this);
            }
        }

        public virtual void Visit<TType>(BinaryBoolComparison<TType, TContext> expression)

        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        #endregion

        #region List

        public virtual void Schedule<TType>(IListExpression<TType, TContext> expression)

        {
            switch (expression)
            {
                case UnaryListExpression<TType, TContext> unaryListExpression:
                    Visit(unaryListExpression);
                    break;
                case BinaryListExpression<TType, TContext> binaryListExpression:
                    Visit(binaryListExpression);
                    break;
                case ConditionalListExpression<TType, TContext> ternaryListExpression:
                    Visit(ternaryListExpression);
                    break;
                case TerminalListExpression<TType, TContext> terminalListExpression:
                    Visit(terminalListExpression);
                    break;
            }
        }

        public virtual void Visit<TType>(UnaryListExpression<TType, TContext> expression)

        {
            expression.Expression.Visit(this);
        }

        public virtual void Visit<TType>(BinaryListExpression<TType, TContext> expression)

        {
            expression.Lhs.Visit(this);
            expression.Rhs.Visit(this);
        }

        public virtual void Visit<T1, T2>(TernaryListExpression<T1, T2, TContext> expression)

        {
            expression.Condition.Visit(this);
            expression.FailExpression.Visit(this);
            expression.PassExpression.Visit(this);
        }

        public virtual void Visit<TType>(TerminalListExpression<TType, TContext> expression) { }

        public void Visit<TType>(UnaryListItemExpression<TType, TContext> expression)

        {
            expression.Expression.Visit(this);
        }

        #endregion
    }
}