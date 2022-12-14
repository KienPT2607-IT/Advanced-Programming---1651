using System;

/* try
{
    System.Console.Write("Input a: ");
    int a = int.Parse(Console.ReadLine());
    System.Console.Write("Input b: ");
    int b = int.Parse(Console.ReadLine());
    int c = a / b;
    System.Console.WriteLine($"Result: {c}");
}
catch (FormatException)
{
    System.Console.WriteLine("Invalid input");
}
catch (DivideByZeroException)
{
    System.Console.WriteLine("Divided by zero");
} */

Console.Write("Length of the array: ");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
int sum = 0; // not declared
for (int i = 0; i < n; i++) // i <= n: IndexOutOfRangeException
{
    Console.Write($"Enter a[{i}]: ");
    try
    {
        a[i] = int.Parse(Console.ReadLine());
        sum += a[i];
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Invalid format");
    }
}

int lower = 0, upper = 0;
try
{
    Console.Write("Enter lower: ");
    lower = int.Parse(Console.ReadLine());
    Console.Write("Enter upper: ");
    upper = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    System.Console.WriteLine("Invalid format");
}

if (lower > upper)
{
    System.Console.WriteLine("Invalid range");
}

int partialSum = 0;
for (int i = lower; i <= upper; i++)
{
    try
    {
        partialSum += a[i];
    }
    catch (IndexOutOfRangeException)
    {
        System.Console.WriteLine("Index out of range");
        break;
    }
}

try
{
    double rate = partialSum * 1.0 / sum; // int / int
    System.Console.WriteLine($"Rate: {rate}");
}
catch (DivideByZeroException)
{
    System.Console.WriteLine("Divided by zero");
}