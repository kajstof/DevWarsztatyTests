using System;
using Shouldly;

namespace Calculator.Tests
{
    public class InitialDataTestsFixture
    {
        CalculatorLib _calculator;

        public InitialDataTestsFixture()
        {
            _calculator = new CalculatorLib();
        }

        public void SetInitialData(int value)
        {
            _calculator.Value = value;
        }

        public void assert_initial_value_return_0(int value)
        {
            _calculator.Value.ShouldBe(value);
        }
    }
}