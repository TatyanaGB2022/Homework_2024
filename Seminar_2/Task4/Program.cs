// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры 
//через запятую.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int divider = 1;
while (number / divider >= 10) 
{
divider *= 10;
}

while (divider > 0)
{
  int digit = number / divider;
  Console.Write(digit);
  number %= divider;
  divider /= 10;
  if (divider > 0)
  {
    Console.Write(", ");
  }
}