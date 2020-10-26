using Aptacode.Expressions;
using Aptacode.Expressions.Bool.Comparison;
using Aptacode.Expressions.Integer;
using Xunit;

namespace Expressions.Tests.Boolean.Comparison
{
    public class Comparison_Tests
    {
        private readonly IContext context;

        [Fact]
        public void EqualTo()
        {
            //Arrange
            var IsEqual = new EqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut = IsEqual.Interpret(context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void GreaterThan()
        {
            //Arrange
            var IsGreaterThan =
                new GreaterThan<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            //Act 
            var sut = IsGreaterThan.Interpret(context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void GreaterThanOrEqualTo()
        {
            //Arrange
            var IsGreaterThan =
                new GreaterThanOrEqualTo<IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
            var IsEqual =
                new GreaterThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut1 = IsGreaterThan.Interpret(context);
            var sut2 = IsEqual.Interpret(context);

            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
        }


        [Fact]
        public void LessThan()
        {
            //Arrange
            var IsLessThan = new LessThan<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(2));
            //Act 
            var sut = IsLessThan.Interpret(context);
            //Assert
            Assert.True(sut);
        }

        [Fact]
        public void LessThanOrEqualTo()
        {
            //Arrange
            var IsLessThan =
                new LessThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(2));
            var IsEqual =
                new LessThanOrEqualTo<IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
            //Act 
            var sut1 = IsLessThan.Interpret(context);
            var sut2 = IsEqual.Interpret(context);

            //Assert
            Assert.True(sut1);
            Assert.True(sut2);
        }
    }
}