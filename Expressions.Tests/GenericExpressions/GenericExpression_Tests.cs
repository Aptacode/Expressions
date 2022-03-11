using Aptacode.Expressions.Bool;
using Aptacode.Expressions.GenericExpressions;
using Moq;
using Xunit;

namespace Expressions.Tests.GenericExpressions;

public class GenericExpression_Tests
{
    private readonly IContext _context;
    private readonly IType _typeObject1;
    private readonly IType _typeObject2;

    public GenericExpression_Tests()
    {
        _context = new Mock<IContext>().Object;
        _typeObject1 = new Mock<IType>().Object;
        _typeObject2 = new Mock<IType>().Object;
    }

    [Fact]
    public void ConstantExpression_OfGenericType_Evaluatesto_AnExpression_WithValue_OfGivenType_Test()
    {
        //Arrange
        var constantExpression =
            new ConstantExpression<IType, IContext>(_typeObject1);
        //Act
        var sut = constantExpression.Interpret(_context);
        //Assert
        Assert.Equal(_typeObject1, sut);
    }

    [Fact]
    public void
        ConditionalExpression_OfGenericType_EvaluatesToFailExpression_WithValue_OfGivenType_OnFalseCondition_Test()
    {
        //Arrange
        var conditionalExpression = new ConditionalExpression<IType, IContext>(new ConstantBool<IContext>(false),
            new ConstantExpression<IType, IContext>(_typeObject1),
            new ConstantExpression<IType, IContext>(_typeObject2));
        //Act
        var sut = conditionalExpression.Interpret(_context);
        //Assert
        Assert.Equal(_typeObject2, sut);
    }

    [Fact]
    public void
        ConditionalExpression_OfGenericType_EvaluatesToPassExpression_WithValue_OfGivenType_OnTrueCondition_Test()
    {
        //Arrange
        var conditionalExpression = new ConditionalExpression<IType, IContext>(new ConstantBool<IContext>(true),
            new ConstantExpression<IType, IContext>(_typeObject1),
            new ConstantExpression<IType, IContext>(_typeObject2));
        //Act
        var sut = conditionalExpression.Interpret(_context);
        //Assert
        Assert.Equal(_typeObject1, sut);
    }
}