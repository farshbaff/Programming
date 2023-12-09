using ConsoleApp1.Enums;

namespace ConsoleApp1.Services;

public class BmiService
{
    public static double GetBmi(double weightInKg, double heightInMeters)
    {
        double bmi = weightInKg / (heightInMeters * heightInMeters);
        return bmi;
    }

    public static BmiHealthStatus GetBmiHealthStatus(double weightInKg, double heightInMeters)
    {
        var bmi = GetBmi(weightInKg, heightInMeters);

        BmiHealthStatus bmiHealthStatus;

        if (bmi < 18.5)
            bmiHealthStatus = BmiHealthStatus.Underweight;
        else if (bmi <= 24.9)
            bmiHealthStatus = BmiHealthStatus.Healthy;
        else if (bmi <= 29.9)
            bmiHealthStatus = BmiHealthStatus.Overweight;
        else
            bmiHealthStatus = BmiHealthStatus.Obese;

        return bmiHealthStatus;
    }
}