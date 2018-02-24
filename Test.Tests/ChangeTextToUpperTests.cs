using System;
using Xunit;
using Shouldly;

namespace Test.Tests
{
    public class ChangeTextToUpperTests
    {
        private  UpperCaseTestFixture _fixture;

        public ChangeTextToUpperTests()
        {
            _fixture = new UpperCaseTestFixture();
        }

        [Theory]
        [InlineData("test1")]
        [InlineData("test2")]
        [InlineData("test3")]
        public void change_text_upper_case(string text)
        {
            // Arrange
            _fixture.SetTextToChange("test");

            // Act
            var result = Execute();
            
            // Assert
            _fixture.assert_text_are_upper_case(result);
        }

        private string Execute() => _fixture.Execute();
    }
}
