using System;
using Shouldly;

namespace Test
{
    public class UpperCaseTestFixture
    {
        UpperCaseChange _upperCaseChange;
        String _text;
        public UpperCaseTestFixture () {
            _upperCaseChange = new UpperCaseChange ();
        }

        public void SetTextToChange (string text) {
            _text = text;
        }

        public void assert_text_are_upper_case(string result)
        {
            var upperCase = _text.ToUpper();
            result.ShouldBe(upperCase);
        }

        public string Execute()
        {
            return _upperCaseChange.Change(_text);
        }
    }
}
