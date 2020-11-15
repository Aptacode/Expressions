using Aptacode.Expressions;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Expression;
using Expressions.Tests.Boolean.Comparison;
using Moq;
using Xunit;

namespace Expressions.Tests.Boolean.Expression
{
    public class Expression_Tests
    {
        public Expression_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        private readonly IContext _context;

        [Fact]
        public void And()
        {
            //Arrange
            var trueAndTrue = new And<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var trueAndFalse = new And<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var falseAndTrue = new And<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var falseAndFalse = new And<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = trueAndTrue.Interpret(_context);
            var sut2 = trueAndFalse.Interpret(_context);
            var sut3 = falseAndTrue.Interpret(_context);
            var sut4 = falseAndFalse.Interpret(_context);
            //Assert
            Assert.True(sut1);
            Assert.False(sut2);
            Assert.False(sut3);
            Assert.False(sut4);
        }

        [Fact]
        public void Not()
        {
            //Arrange
            var trueConstant = new ConstantBool<IContext>(true);
            //Act
            var sut = new Not<IContext>(trueConstant).Interpret(_context);
            //Assert
            Assert.False(sut);
        }

        [Fact]
        public void Or()
        {
            //Arrange
            var trueOrTrue = new Or<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var trueOrFalse = new Or<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var falseOrTrue = new Or<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var falseOrFalse = new Or<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = trueOrTrue.Interpret(_context);
            var sut2 = trueOrFalse.Interpret(_context);
            var sut3 = falseOrTrue.Interpret(_context);
            var sut4 = falseOrFalse.Interpret(_context);
            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
            Assert.True(sut3);
            Assert.False(sut4);
        }

        [Fact]
        public void XOr()
        {
            //Arrange
            var trueXOrTrue = new XOr<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var trueXOrFalse = new XOr<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var falseXOrTrue = new XOr<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var falseXOrFalse = new XOr<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = trueXOrTrue.Interpret(_context);
            var sut2 = trueXOrFalse.Interpret(_context);
            var sut3 = falseXOrTrue.Interpret(_context);
            var sut4 = falseXOrFalse.Interpret(_context);
            //Assert
            Assert.False(sut1);
            Assert.True(sut2);
            Assert.True(sut3);
            Assert.False(sut4);
        }
    }
}