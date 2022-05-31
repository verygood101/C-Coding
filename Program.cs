// See https://aka.ms/new-console-template for more information

double num1;
double num2;
double num3;

Console.WriteLine("Input number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input number 1: ");
num3 = Convert.ToDouble(Console.ReadLine());

double average = (num1 + num2 + num3)/3;
Console.Write("The average is " + average);
Console.ReadLine();

