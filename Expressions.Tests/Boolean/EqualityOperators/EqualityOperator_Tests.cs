using Aptacode.Expressions.Bool.EqualityOperators;
using Aptacode.Expressions.Integer;
using Moq;
using Xunit;

namespace Expressions.Tests.Boolean.EqualityOperators
{
    public class EqualityOperator_Tests
    {
        private readonly IContext _context;

        public EqualityOperator_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        [Fact]
        public void EqualTo()
        {
            //Arrange
            var isEqual =
                new EqualTo<int, IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut = isEqual.Interpret(_context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void NotEqualTo()
        {
            //Arrange
            var isEqual =
                new NotEqualTo<int, IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            //Act 
            var sut = isEqual.Interpret(_context);
            //Assert
            Assert.True(sut);
        }
    }
}