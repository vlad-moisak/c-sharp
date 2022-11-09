using Xunit;

namespace ConsoleApp.Tests;

public class CalculatorTests
{
	[Theory]
	[InlineData(-1, -2)]
	[InlineData(4, 2)]
	[InlineData(7, 6)]
	[InlineData(0, 0)]
	[InlineData(0, -25)]
	[InlineData(0, 50)]
	public void Test_Sum(int a, int b)
	{
		// Arrange.

		var calculator = new Calculator();

		// Act.

		var result = calculator.Sum(a, b);

		// Assert.

		Assert.Equal(a + b, result);
	}
}