using Aptacode.Expressions;
using Aptacode.Expressions.Integer;
using Moq;
using Xunit;

namespace Expressions.Tests.Integer
{
    public class Integer_Tests
    {
        public Integer_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        private readonly IContext _context;

        [Fact]
        public void Add()
        {
            //Arrange
            //Act
            var sut = new Add<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Assert
            Assert.Equal(2, sut.Interpret(_context));
        }

        [Fact]
        public void Multiply()
        {
            //Arrange
            //Act
            var sut = new Multiply<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(2));
            //Assert
            Assert.Equal(4, sut.Interpret(_context));
        }

        [Fact]
        public void Subtract()
        {
            //Arrange
            //Act
            var sut = new Subtract<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            //Assert
            Assert.Equal(1, sut.Interpret(_context));
        }
    }
}