using Aptacode.Expressions;
using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.Json;
using Newtonsoft.Json;
using Xunit;

namespace Expressions.Tests.Json
{
    public class Json_Tests
    {
        [Fact]
        public void GetAllInputs_Successfully_Returns_ListOfInputs()
        {
            //Arrange
            var isGreaterThan =
                new GreaterThanOrEqualTo<int, IContext>(new ConstantInteger<IContext>(2),
                    new ConstantInteger<IContext>(1));

            //Act
            var intExpressions = ExpressionsJsonExtensions.IntExpressions<IContext>();
            var boolExpressions = ExpressionsJsonExtensions.BoolExpressions<IContext>().ExtendBoolExpressions<int, IContext>();
            var settings = new JsonSerializerSettings().Add(intExpressions).Add(boolExpressions);

            var json = JsonConvert.SerializeObject(isGreaterThan, settings);

            var result = JsonConvert.DeserializeObject<IExpression<bool,IContext>>(json, settings);


            //Assert
            Assert.True(isGreaterThan.Equals(result));
        }
    }
}