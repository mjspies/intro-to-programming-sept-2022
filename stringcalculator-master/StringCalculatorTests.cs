
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void OneNumberReturnsThatNumber()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1");

        Assert.Equal(1, result);
    }

    [Fact]
    public void TwoNumbersReturnsTheirSum()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,3");

        Assert.Equal(4, result);

    }
    [Fact]
    public void ThreeNumbersReturnsTheirSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1, 2, 3");
        Assert.Equal(6, result);
    }

    [Fact]
    public void UseNewLineDelimeter()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2\n3");
        Assert.Equal(6, result);
    }

    [Fact]
    public void UseAnyDelimeter()
    {
        var calculater = new StringCalculator();
        // 1 + 3 + 8 + 9 +10 = 31
        var result = calculater.Add("1,3dsfns8;9>>>>>>>\r\n10");
        Assert.Equal(31, result);
    }


    [Fact]
    public void IgnoreNumbersOverOneThousand()
    {
        var calculater = new StringCalculator();
        // 1 + 3 + 8 + 9 +10 = 31
        var result = calculater.Add("2,1001");
        Assert.Equal(2, result);
    }
}
