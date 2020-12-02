﻿using Aptacode.Expressions.Bool.EqualityOperators;
using Aptacode.Expressions.Bool.RelationalOperators;
using Aptacode.Expressions.Integer;
using Expressions.Tests;
using Moq;
using Xunit;

namespace Expressions.Tests.Boolean
{
    public class EqualityOperator_Tests
    {
        public EqualityOperator_Tests()
        {
            _context = new Mock<IContext>().Object;
        }

        private readonly IContext _context;

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