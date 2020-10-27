using Aptacode.Expressions;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Integer;
using Moq;
using Xunit;

namespace Expressions.Tests.Boolean.Comparison
{
    public class Comparison_Tests
    {
        private readonly IContext _context;
        public Comparison_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        [Fact]
        public void EqualTo()
        {
            //Arrange
            var isEqual = new EqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut = isEqual.Interpret(_context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void GreaterThan()
        {
            //Arrange
            var isGreaterThan =
                new GreaterThan<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            //Act 
            var sut = isGreaterThan.Interpret(_context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void GreaterThanOrEqualTo()
        {
            //Arrange

            var isGreaterThan =
                new GreaterThanOrEqualTo<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            var isEqual =
                new GreaterThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut1 = isGreaterThan.Interpret(_context);
            var sut2 = isEqual.Interpret(_context);

            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
        }


        [Fact]
        public void LessThan()
        {
            //Arrange
            var isLessThan = new LessThan<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(2));
            //Act 
            var sut = isLessThan.Interpret(_context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void LessThanOrEqualTo()
        {
            //Arrange
            var isLessThan = new LessThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(2));
            var isEqual = new LessThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));

            //Act 
            var sut1 = isLessThan.Interpret(_context);
            var sut2 = isEqual.Interpret(_context);

            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
        }
    }
}