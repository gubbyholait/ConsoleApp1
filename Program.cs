// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");
Console.Write("Enter a number to see if it is odd or even : ");

int inputNumber=0;
inputNumber = System.Convert.ToInt32(Console.ReadLine());
if (IsEven(inputNumber))
{
    Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALE");
}

Console.WriteLine(IsEven(inputNumber));
Console.WriteLine(AddNumbers());
Console.WriteLine(GetSmallestNo(78, 12));
/*
 This allows code two numbers to be added
 */
static int AddNumbers()
{
    int firstNumber, secondNumber;
    int totalNumber = 0;
    try
    {
        firstNumber = 35;
        secondNumber = 45;
        Console.WriteLine($"I am adding the values {firstNumber} and {secondNumber}");
        totalNumber = firstNumber + secondNumber;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    { }
    return totalNumber;
}

static int GetSmallestNo( int firstNumber, int secondNumber)
{ 
  Console.WriteLine($"I am returning the number of the lowest of {firstNumber} and {secondNumber}");
  return firstNumber < secondNumber ? firstNumber : secondNumber;

}
static bool IsEven( int num)
{
    // Return true or false depending on whether the number is odd or even
    return (num % 2 == 0);
}