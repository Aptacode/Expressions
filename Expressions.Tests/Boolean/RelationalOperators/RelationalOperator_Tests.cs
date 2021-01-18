using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Integer;
using Moq;
using Xunit;

namespace Expressions.Tests.Boolean.RelationalOperators
{
    public class RelationalOperators_Tests
    {
        private readonly IContext _context;

        public RelationalOperators_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        [Fact]
        public void GreaterThan()
        {
            //Arrange
            var isGreaterThan =
                new GreaterThan<int, IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
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
                new GreaterThanOrEqualTo<int, IContext>(new ConstantInteger<IContext>(2),
                    new ConstantInteger<IContext>(1));
            var isEqual =
                new GreaterThanOrEqualTo<int, IContext>(new ConstantInteger<IContext>(1),
                    new ConstantInteger<IContext>(1));
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
            var isLessThan =
                new LessThan<int, IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(2));
            //Act 
            var sut = isLessThan.Interpret(_context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void LessThanOrEqualTo()
        {
            //Arrange
            var isLessThan =
                new LessThanOrEqualTo<int, IContext>(new ConstantInteger<IContext>(1),
                    new ConstantInteger<IContext>(2));
            var isEqual =
                new LessThanOrEqualTo<int, IContext>(new ConstantInteger<IContext>(1),
                    new ConstantInteger<IContext>(1));

            //Act 
            var sut1 = isLessThan.Interpret(_context);
            var sut2 = isEqual.Interpret(_context);

            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
        }
    }
}