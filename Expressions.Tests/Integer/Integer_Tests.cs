using Aptacode.Expressions.GenericArithmeticOperators;
using Aptacode.Expressions.Integer;
using Moq;
using Xunit;

namespace Expressions.Tests.Integer;

public class Integer_Tests
{
    private readonly IContext _context;

    public Integer_Tests()
    {
        _context = new Mock<IContext>().Object;
    }

    [Fact]
    public void Add_SuccessfullyAdds_Two_ConstantIntegers_Test()
    {
        //Arrange
        var addExpression =
            new Add<int, IContext>(new ConstantInteger<IContext>(1), new ConstantInteger<IContext>(1));
        //Act
        var sut = addExpression.Interpret(_context);
        //Assert
        Assert.Equal(2, sut);
    }

    [Fact]
    public void Multiply_SuccessfullyMultiplies_Two_ConstantIntegers_Test()
    {
        //Arrange
        var multiplyExpression =
            new Multiply<int, IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(2));
        //Act
        var sut = multiplyExpression.Interpret(_context);
        //Assert
        Assert.Equal(4, sut);
    }

    [Fact]
    public void Subtract_SuccessfullySubtracts_Two_ConstantIntegers_Test()
    {
        //Arrange
        var subtractExpression =
            new Subtract<int, IContext>(new ConstantInteger<IContext>(2), new ConstantInteger<IContext>(1));
        //Act
        var sut = subtractExpression.Interpret(_context);
        //Assert
        Assert.Equal(1, sut);
    }
}