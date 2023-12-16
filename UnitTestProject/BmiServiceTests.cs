using ConsoleApp1.Enums;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject;

public class BmiServiceTests
{
    [Theory]
    [InlineData(60, 1.65, 22.03856749)] // Healthy Weight
    [InlineData(70, 1.80, 21.60493827)] // Healthy Weight
    [InlineData(50, 1.65, 18.36547291)] // Underweight
    [InlineData(90, 1.70, 31.14186851)] // Obese
    public void GetBmi_ShouldCalculateCorrectBmi(double weight, double height, double expectedBmi)
    {
        // Act
        var result = BmiService.GetBmi(weight, height);

        // Assert
        Assert.Equal(expectedBmi, result, 8);
    }

    [Theory]
    [InlineData(60, 1.65, BmiHealthStatus.Healthy)]
    [InlineData(70, 1.80, BmiHealthStatus.Healthy)]
    [InlineData(50, 1.65, BmiHealthStatus.Underweight)]
    [InlineData(90, 1.70, BmiHealthStatus.Obese)]
    public void GetBmiHealthStatus_ShouldReturnCorrectStatus(double weight, double height, BmiHealthStatus expectedStatus)
    {
        // Act
        var result = BmiService.GetBmiHealthStatus(weight, height);

        // Assert
        Assert.Equal(expectedStatus, result);
    }
}