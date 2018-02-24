using System;
using Xunit;

namespace Calculator.Tests
{
    public class InitialDataTests
    {
        [Fact]
        public void return_0__when__set_initial_data_to_0()
        {
            // Arrange
            _fixture.SetInitialData(0);

            // Act
            // var result = Act();
            
            // Assert
            _fixture.assert_initial_value_return_0(0);
        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            // Arrange
            // _fixture.SetInitialData();

            // Act
            // var result = Act();
            
            // Assert
            _fixture.assert_initial_value_return_0(0);
        }

        private InitialDataTestsFixture _fixture;

        public InitialDataTests()
        {
            _fixture = new InitialDataTestsFixture();
        }
    }
}
