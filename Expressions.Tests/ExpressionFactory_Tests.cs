using Aptacode.Expressions;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Bool.Expression;
using Aptacode.Expressions.Bool.Extensions;
using Aptacode.Expressions.Color;
using Aptacode.Expressions.List;
using Aptacode.Expressions.Decimal;
using Aptacode.Expressions.Double;
using Aptacode.Expressions.Float;
using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.Guid;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Numeric.Extensions;
using Aptacode.Expressions.String;
using Expressions.Tests.Boolean.Comparison;
using Moq;
using System;
using System.Drawing;
using Xunit;

namespace Expressions.Tests
{
    public class ExpressionFactory_Tests
    {
        public ExpressionFactory_Tests()
        {
            _context = new Mock<IContext>().Object;
            _expressions = new Mock<ExpressionFactory<IContext>>().Object;
        }

        private readonly IContext _context;
        private readonly ExpressionFactory<IContext> _expressions;


        [Fact]
        public void ExpressionFactoryBool_SuccessfullyCreates_ConstantBoolExpression_Test()
        {
            //Arrange
            var constantBool = new ConstantBool<IContext>(true);
            //Act
            var sut = _expressions.Bool(true);
            //Assert
            Assert.True(new EqualTo<bool, IContext>(constantBool, sut).Interpret(_context));
        }

        [Fact]
        public void ExpressionFactoryInt_SuccessfullyCreates_ConstantIntegerExpression_Test()
        {
            //Arrange
            var constantInt = new ConstantInteger<IContext>(1);
            //Act
            var sut = _expressions.Int(1);
            //Assert
            Assert.True(new EqualTo<int, IContext>(constantInt, sut).Interpret(_context));
        }
        
        [Fact]
        public void ExpressionFactoryFloat_SuccessfullyCreates_ConstantFloatExpression_Test()
        {
            //Arrange
            var floatPi = new ConstantFloat<IContext>(3.1415f);
            //Act
            var sut = _expressions.Float(3.1415f);
            //Assert
            Assert.True(new EqualTo<float, IContext>(floatPi, sut).Interpret(_context));
        }
        
        [Fact]
        public void ExpressionFactoryDouble_SuccessfullyCreates_ConstantDoubleExpression_Test()
        {
            //Arrange
            var constantDouble = new ConstantDouble<IContext>(0.99);
            //Act
            var sut = _expressions.Double(0.99);
            //Assert
            Assert.True(new EqualTo<double, IContext>(constantDouble, sut).Interpret(_context));
        }
        
        [Fact]
        public void ExpressionFactoryDecimal_SuccessfullyCreates_ConstantDecimalExpression_Test()
        {
            //Arrange
            var constantDecimal = new ConstantDecimal<IContext>(1.23m);
            //Act
            var sut = _expressions.Decimal(1.23m);
            //Assert
            Assert.True(new EqualTo<decimal, IContext>(constantDecimal, sut).Interpret(_context));
        }
        
        [Fact]
        public void ExpressionFactoryGuid_SuccessfullyCreates_ConstantGuidExpression_Test()
        {
            //Arrange
            var constantGuid = new ConstantGuid<IContext>(Guid.Parse("9f3a43e8-43db-4115-87ef-20398ead7ae5"));
            //Act
            var sut = _expressions.Guid(Guid.Parse("9f3a43e8-43db-4115-87ef-20398ead7ae5"));
            //Assert
            Assert.True(new EqualTo<Guid, IContext>(constantGuid, sut).Interpret(_context));
        }

        //[Fact]
        //public void ExpressionFactoryColor_SuccessfullyCreates_ConstantColorExpression_Test()
        //{
        //    //Arrange
        //    var constantColor = new ConstantColor<IContext>(Color.Red);
        //    //Act
        //    var sut = _expressions.Color(Color.Red);
        //    //Assert
        //    Assert.True(new EqualTo<Color, IContext>(constantColor, sut).Interpret(_context));
        //}

        

        [Fact]
        public void ExpressionFactorySList_SuccessfullyCreates_ConstantListExpression_Test()
        {
            //Arrange
            var constantList = new ConstantList<int, IContext>( new int[] { 1, 1 });
            //Act
            var sut = _expressions.List( new int[] { 1, 1 });
            //Assert
            Assert.True(new EqualTo<int[], IContext>(constantList, sut).Interpret(_context));
        }
        
        [Fact]
        public void ExpressionFactoryString_SuccessfullyCreates_ConstantStringExpression_Test()
        {
            //Arrange
            var constantString = new ConstantString<IContext>("foo");
            //Act
            var sut = _expressions.String("foo");
            //Assert
            Assert.True(new EqualTo<string, IContext>(constantString, sut).Interpret(_context));
        }




        [Fact]
        public void And_SuccessfullyCreates_AndExpression_Test()
        {
            //Arrange
            var True = _expressions.Bool(true);
            var TrueAndTrueEx = new And<IContext>(True, True);
            //Act
            var sut = _expressions.And(True, True);
            //Assert
            Assert.Equal(TrueAndTrueEx.Interpret(_context), sut.Interpret(_context));
        }

        [Fact]
        public void EqualTo_ReturnsFalse_WhenExpressionsAreNotEqual_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.EqualTo(ex1, ex2);
            //Assert
            Assert.False(sut.Interpret(_context));
        }

        [Fact]
        public void EqualTo_ReturnsTrue_WhenExpressionsAreEqual_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(0);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.EqualTo(ex1, ex2);
            //Assert
            Assert.True(sut.Interpret(_context));
        }

        [Fact]
        public void ExpressionFactory_Add_SuccessfullyAdds_Two_IntegerExpressions_Test()
        {
            //Arrange
            var int1 = _expressions.Int(1);
            var int2 = _expressions.Int(1);
            //Act
            var sut = _expressions.Add(int1, int2);
            //Assert
            Assert.Equal(2, sut.Interpret(_context));
        }

        [Fact]
        public void ExpressionFactory_Multiply_SuccessfullyMultiplies_Two_IntegerExpressions_Test()
        {
            //Arrange
            var int1 = _expressions.Int(2);
            var int2 = _expressions.Int(2);
            //Act
            var sut = _expressions.Multiply(int1, int2);
            //Assert
            Assert.Equal(4, sut.Interpret(_context));
        }

        [Fact]
        public void ExpressionFactory_Subtract_SuccessfullySubtracts_Two_IntegerExpressions_Test()
        {
            //Arrange
            var int1 = _expressions.Int(1);
            var int2 = _expressions.Int(1);
            //Act
            var sut = _expressions.Subtract(int1, int2);
            //Assert
            Assert.Equal(0, sut.Interpret(_context));
        }



        [Fact]
        public void ExpressionFactoryConditional_SuccessfullyCreates_ConditionalIntegerExpression_Test()
        {
            //Arrange
            var intConditional =
                new ConditionalExpression<int, IContext>(_expressions.Bool(true), _expressions.Int(1),
                    _expressions.Int(0));
            //Act
            var sut = _expressions.Conditional(_expressions.Bool(true), _expressions.Int(1), _expressions.Int(0));
            //Assert
            Assert.True(_expressions.EqualTo(intConditional, sut).Interpret(_context));
        }



        [Fact]
        public void GreaterThan_ReturnsFalse_When_LHS_IsNot_GreaterThan_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.GreaterThan(ex2, ex1);
            //Assert
            Assert.False(sut.Interpret(_context));
        }

        [Fact]
        public void GreaterThan_ReturnsTrue_When_LHS_Is_GreaterThan_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.GreaterThan(ex1, ex2);
            //Assert
            Assert.True(sut.Interpret(_context));
        }

        [Fact]
        public void GreaterThanOrEqualTo_ReturnsFalse_When_LHS_IsNot_GreaterThanOrEqualTo_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);

            //Act
            var sut = _expressions.GreaterThanOrEqualTo(ex2, ex1);

            //Assert
            Assert.False(sut.Interpret(_context));
        }

        [Fact]
        public void GreaterThanOrEqualTo_ReturnsTrue_When_LHS_Is_GreaterThanOrEqualTo_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            var ex3 = _expressions.Int(0);
            //Act
            var sut1 = _expressions.GreaterThanOrEqualTo(ex1, ex2);
            var sut2 = _expressions.GreaterThanOrEqualTo(ex2, ex3);
            //Assert
            Assert.True(sut1.Interpret(_context));
            Assert.True(sut2.Interpret(_context));
        }

        [Fact]
        public void LessThan_ReturnsFalse_When_LHS_IsNot_LessThan_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.LessThan(ex1, ex2);
            //Assert
            Assert.False(sut.Interpret(_context));
        }

        [Fact]
        public void LessThan_ReturnsTrue_When_LHS_Is_LessThan_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.LessThan(ex2, ex1);
            //Assert
            Assert.True(sut.Interpret(_context));
        }

        [Fact]
        public void LessThanOrEqualTo_ReturnsFalse_When_LHS_IsNot_LessThanOrEqualTo_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            //Act
            var sut = _expressions.LessThanOrEqualTo(ex1, ex2);
            //Assert
            Assert.False(sut.Interpret(_context));
        }

        [Fact]
        public void LessThanOrEqualTo_ReturnsTrue_When_LHS_Is_LessThanOrEqualTo_RHS_Test()
        {
            //Arrange
            var ex1 = _expressions.Int(1);
            var ex2 = _expressions.Int(0);
            var ex3 = _expressions.Int(0);
            //Act
            var sut1 = _expressions.LessThanOrEqualTo(ex2, ex1);
            var sut2 = _expressions.LessThanOrEqualTo(ex2, ex3);
            //Assert
            Assert.True(sut1.Interpret(_context));
            Assert.True(sut2.Interpret(_context));
        }

        [Fact]
        public void Not_SuccessfullyCreates_NotExpression_Test()
        {
            //Arrange
            var True = _expressions.Bool(true);
            var NotTrueEx = new Not<IContext>(True);
            //Act
            var sut = _expressions.Not(True);
            //Assert
            Assert.Equal(NotTrueEx.Interpret(_context), sut.Interpret(_context));
        }

        [Fact]
        public void Or_SuccessfullyCreates_OrExpression_Test()
        {
            //Arrange
            var True = _expressions.Bool(true);
            var TrueOrTrueEx = new Or<IContext>(True, True);
            //Act
            var sut = _expressions.Or(True, True);
            //Assert
            Assert.Equal(TrueOrTrueEx.Interpret(_context), sut.Interpret(_context));
        }

        [Fact]
        public void XOr_SuccessfullyCreates_XOrExpression_Test()
        {
            //Arrange
            var True = _expressions.Bool(true);
            var TrueXOrTrueEx = new XOr<IContext>(True, True);
            //Act
            var sut = _expressions.XOr(True, True);
            //Assert
            Assert.Equal(TrueXOrTrueEx.Interpret(_context), sut.Interpret(_context));
        }

        [Fact]
        public void ListTest()
        {
            var fibListExpression = _expressions.List(new int[] { 1, 1 });
            
            for(int i = 0; i < 20; i++)
            {
                fibListExpression = _expressions.List(_expressions.ConditionalList(_expressions.LessThan(_expressions.Last(fibListExpression), _expressions.Int(100)),
                                            _expressions.Append(fibListExpression,
                                                _expressions.Add(_expressions.First(_expressions.TakeLast(fibListExpression, _expressions.Int(2))), _expressions.Last(_expressions.TakeLast(fibListExpression, _expressions.Int(2))))),
                                            fibListExpression).Interpret(_context));
            }

            var sut = fibListExpression.Interpret(_context);
            
            Assert.Equal(13, sut[6]);
            Assert.Equal(21, sut[7]);
            Assert.Equal(34, sut[8]);
        }
    }
}