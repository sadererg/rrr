using ClassLibraryCallkulate.Calc;
using System.Collections.Generic;
namespace noConsole.UnitTests.Calc
{
    public class CalculatorTest
    {
        private readonly ClassLibraryCallkulateCalc _ClassLibraryCallkulateCalc;

        public CalculatorTest()
        {
            _ClassLibraryCallkulateCalc = new ClassLibraryCallkulateCalc();
        }
       
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new string[] { "1", "2", "Add", "3" } };
            yield return new object[] { new string[] { "1", "2", "Sub", "-1" } };
            yield return new object[] { new string[] { "3", "2", "Mul", "6" } };
            yield return new object[] { new string[] { "6", "2", "Div", "3" } };
        }

        [Theory]
        [MemberData(nameof(CalculatorTest.GetTestData), MemberType = typeof(CalculatorTest))]
        public void Calculators(string[] data)
        {            

            // Act
            double result = _ClassLibraryCallkulateCalc.Calc(Convert.ToDouble(data[0]), Convert.ToDouble(data[1]), data[2]);

            // Assert
            Assert.Equal(Convert.ToDouble(data[3]), result,0);
        }
    }
}