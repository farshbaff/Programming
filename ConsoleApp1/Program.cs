using ConsoleApp1;
using ConsoleApp1.Services;

// Increment
//Console.Write("Enter a number: ");
//var num = Convert.ToInt32(Console.ReadLine());

//var mathematicsService = new MathematicsService();
//var result = MathematicsService.Increment(num);

//Console.Write("Result = ");
//Console.WriteLine(result);


//Decrement
//Console.Write("Enter a number to decrement: ");
//var num1 = Convert.ToInt32(Console.ReadLine());

//var mathematicsService = new MathematicsService();
//var decrementresult = MathematicsService.Decrement(num1);

for (int i = 0; i < 10; i++)
{

    var num1 = Convert.ToInt32(Console.ReadLine());
    var num2 = Convert.ToInt32(Console.ReadLine());

    var result = MathematicsService.IsGreaterThan(num1, num2);

    Console.WriteLine(result);
}

//Calculate sum & Average

var sum = 0.0;

for (int i = 0; i < 10; i++)
{
    var num = Convert.ToDouble(Console.ReadLine());
    sum = sum + num;
}

Console.WriteLine(sum);

var average = sum / 10;

//Find maximum

var max = 0.0;

for (int i = 0; i < 10; i++)
{
    var num = Convert.ToDouble(Console.ReadLine());

    if (num > max)
        max = num;
}

Console.WriteLine(max);


//Find minimum

var min = double.MaxValue;

for (int i = 0; i < 10; i++)
{
    var num = Convert.ToDouble(Console.ReadLine());

    if (num < min)
        min = num;
}

Console.WriteLine(min);
