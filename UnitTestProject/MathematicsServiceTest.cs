using ConsoleApp1;
using ConsoleApp1.Services;

namespace UnitTestProject;

public class MathematicsServiceTest
{
    [Fact]
    public void Mathematics_Increment_Test()
    {
        //Arrange
        var num = 1;
        var expected = num + 1;

        //Act
        var actual = MathematicsService.Increment(num);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Mathematics_Decrement_Test()
    {
        //Arrange
        var num = 2;
        var expected = num - 1;

        //Act
        var actual = MathematicsService.Decrement(num);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 3, 5)]
    [InlineData(10, 15, 25)]
    public void Mathematics_Add_Test(int num1, int num2, int expected)
    {
        //Arrange


        //Act
        var actual = MathematicsService.Add(num1, num2);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 1, false)]
    [InlineData(2, 3, false)]
    [InlineData(15, 10, true)]
    public void Mathematics_IsGreaterThan_Test(int num1, int num2, bool expected)
    {
        //Arrange

        //Act
        var actual = MathematicsService.IsGreaterThan(num1, num2);

        //Assert
        Assert.Equal(expected, actual);
    }
}