using ConsoleApp1;
using ConsoleApp1.Services;

// Increment
Console.Write("Enter a number: ");
var num = Convert.ToInt32(Console.ReadLine());

//var mathematicsService = new MathematicsService();
var result = MathematicsService.Increment(num);

Console.Write("Result = ");
Console.WriteLine(result);


//Decrement
Console.Write("Enter a number to decrement: ");
var num1 = Convert.ToInt32(Console.ReadLine());

//var mathematicsService = new MathematicsService();
var decrementresult = MathematicsService.Decrement(num1);

