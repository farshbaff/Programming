namespace ConsoleApp1.Services;

public class MathematicsService
{
    public static int Increment(int num)
    {
        var result = num + 1;
        return result;
    }

    public static int Add(int num1, int num2)
    {
        var result = num1 + num2;
        return result;
    }

    public static int Sub(int num1, int num2)
    {
        var result = num1 - num2;
        return result;
    }

    public static int Mul(int num1, int num2)
    {
        var result = num1 * num2;
        return result;
    }

    public static int Div(int num1, int num2)
    {
        var result = num1 / num2;
        return result;
    }

    public static int Decrement(int num)
    {
        return num - 1;
    }
}
