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

    public static bool IsEven(int num)
    {
        //1.
        return num % 2 == 0;

        //2.
        //return num % 2 == 0 ? true : false;

        //3.
        //var isEven = num % 2 == 0;
        //return isEven;

        //4.
        //if(num % 2 == 0)
        //    return true;
        //else
        //    return false;

    }
    public static bool IsOdd(int num) => num % 2 != 0;

    public static bool IsGreaterThan(int num1, int num2) => num1 > num2;
    public static bool IsGreaterThanOrEqual(int num1, int num2) => num1 >= num2;
}
