using Xunit;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions;
using Aptacode.Expressions.Bool.Comparison;
using Moq;
using Aptacode.Expressions.Bool;
using Aptacode.Expressions.Bool.Expression;

namespace Expressions.Tests.Boolean.Comparison
{
    public class Expression_Tests
    {
        private readonly IContext context;

        [Fact]

        public void And()
        {
            //Arrange
            var TrueAndTrue = new And<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var TrueAndFalse = new And<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var FalseAndTrue = new And<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var FalseAndFalse = new And<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = TrueAndTrue.Interpret(context);
            var sut2 = TrueAndFalse.Interpret(context);
            var sut3 = FalseAndTrue.Interpret(context);
            var sut4 = FalseAndFalse.Interpret(context);
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
            var True = new ConstantBool<IContext>(true);
            //Act
            var sut = new Not<IContext>(True).Interpret(context);
            //Assert
            Assert.False(sut);
        }


        [Fact]

        public void Or()
        {
            //Arrange
            var TrueOrTrue = new Or<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var TrueOrFalse = new Or<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var FalseOrTrue = new Or<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var FalseOrFalse = new Or<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = TrueOrTrue.Interpret(context);
            var sut2 = TrueOrFalse.Interpret(context);
            var sut3 = FalseOrTrue.Interpret(context);
            var sut4 = FalseOrFalse.Interpret(context);
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
            var TrueXOrTrue = new XOr<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(true));
            var TrueXOrFalse = new XOr<IContext>(new ConstantBool<IContext>(true), new ConstantBool<IContext>(false));
            var FalseXOrTrue = new XOr<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(true));
            var FalseXOrFalse = new XOr<IContext>(new ConstantBool<IContext>(false), new ConstantBool<IContext>(false));
            //Act 
            var sut1 = TrueXOrTrue.Interpret(context);
            var sut2 = TrueXOrFalse.Interpret(context);
            var sut3 = FalseXOrTrue.Interpret(context);
            var sut4 = FalseXOrFalse.Interpret(context);
            //Assert
            Assert.False(sut1);
            Assert.True(sut2);
            Assert.True(sut3);
            Assert.False(sut4);
        }
    }
}
