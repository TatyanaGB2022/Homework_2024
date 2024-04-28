// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// Пример 
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

void Main()
{
  while (true)
  {
    Console.Write("Введите целое число или q для выхода: ");
    string? input = Console.ReadLine();

    if(input!.ToLower() == "q")
    {
      System.Console.WriteLine("Введено q. Программа завершается.");
      break;
    }
    int number;
    if (!int.TryParse(input, out number))
    {
      Console.WriteLine("Некорректный ввод! ");
      continue;
    }

    if (GetSumDigits(number) % 2 == 0)
    {
      Console.WriteLine("Сумма цифр {0} четная. Программа завершается.", number);
      break;
    }

  }
  int GetSumDigits(int number)
  {
    int sum = 0;
    number = Math.Abs(number);

    while (number > 0)
    {
      sum += number % 10;
      number /= 10;
    }
    return sum;
  }
}

Main();