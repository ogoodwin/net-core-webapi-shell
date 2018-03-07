using NetCoreWebApiShell.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetCoreWebApiShell.Api.Tests.Controllers
{
    public class ValuesControllerTests
    {
        private readonly ValuesController _target;

        public ValuesControllerTests()
        {
            _target = new ValuesController();
        }

        [Fact]
        public void Get_ValidId_ReturnedExpectedResult()
        {
            //Arrange
            var id = 1;
            var expected = "value";

            //Act
            var result = _target.Get(id);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
