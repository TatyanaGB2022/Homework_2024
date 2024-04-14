// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10;
int secondNumber = number % 10;

System.Console.WriteLine($"Наибольшая цифра в числе: {number}");
if (secondNumber > firstNumber)
{
  System.Console.WriteLine($"Больше цифра: {secondNumber}");
}
else
{
  System.Console.WriteLine($"Больше цифра: {firstNumber}");
}