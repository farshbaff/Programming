using ConsoleApp1.Enums;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject;

public class ArrayServiceTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, 7)] // Healthy Weight
    [InlineData(new int[] { 1, 2, 4, 5, 6 }, 18)] // Healthy Weight
    [InlineData(new int[] { 4, 9, 7, 1, 8, 6, 12, 31, 4, 11 }, 93)]
    public void Array_Sum(int[] nums, int expected)
    {
        //Arrang

        // Act
        var actual = ArrayService.GetSum(nums);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, 2.33)] // Healthy Weight
    [InlineData(new int[] { 1, 2, 4, 5, 6 }, 3.6)] // Healthy Weight
    [InlineData(new int[] { 4, 9, 7, 1, 8, 6, 12, 31, 4, 11 }, 9.3)]
    public void Array_Average(int[] nums, double expected)
    {
        //Arrang

        // Act
        var actual = ArrayService.GetAverage(nums);

        // Assert
        //تا دو رقم اعشار چک کند
        Assert.Equal(expected, actual, 2);
    }

    [Theory]
    [InlineData(new int[] { 4, 2, 1 }, 4)] // Healthy Weight
    [InlineData(new int[] { 1, 2, 6, 5, 4 }, 6)] // Healthy Weight
    [InlineData(new int[] { 4, 9, 7, 1, 8, 6, 12, 31, 4, 11 }, 31)]
    public void Array_Max(int[] nums, int expected)
    {
        //Arrang

        // Act
        var actual = ArrayService.GetMax(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new int[] { 4, 2, 1 }, 1)] // Healthy Weight
    [InlineData(new int[] { 1, 2, 6, 5, 4 }, 1)] // Healthy Weight
    [InlineData(new int[] { 4, 9, 7, 16, 8, 6, 12, 31, 4, 11 }, 4)]
    public void Array_Min(int[] nums, int expected)
    {
        //Arrang

        // Act
        var actual = ArrayService.GetMin(nums);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 4, 2, 1 }, 7, 2.33, 1, 4)] // Healthy Weight
    public void Array_GetSumAvgMaxMin(int[] nums, int expectedSum, double expectedAverage, int expectedMin, int expectedMax)
    {
        //Arrang

        // Act
        var (actualSum, actualAverage, actualMin, actualMax) = ArrayService.GetSumAvgMaxMin(nums);

        // Assert
        Assert.Equal(expectedSum, actualSum);
        Assert.Equal(expectedAverage, actualAverage, 2);
        Assert.Equal(expectedMin, actualMin);
        Assert.Equal(expectedMax, actualMax);
    }
}