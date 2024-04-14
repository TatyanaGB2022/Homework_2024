// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
  System.Console.Write($"{message} > ");
  return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int xCoord, int yCoord)
{
  if (xCoord == 0 || yCoord == 0)
  {
    System.Console.WriteLine("Точка лежит хотя бы  на одной из осей");
    return false;
  }

  return true;
}

  int GetQuorter(int xCoord, int yCoord)
  {
    if (xCoord > 0 && yCoord > 0)
    {
      return 1;
    }
      if (xCoord > 0 && yCoord < 0)
      {
        return 4;
      }
        if (xCoord < 0 && yCoord > 0)
        {
          return 2;
        }
        return 3;
      }
      int x = Prompt("Введите х");
      int y = Prompt("Введите у");
      if (ValidateCoords(x, y))
      {
        int quorter = GetQuorter(x, y);
        System.Console.WriteLine($"Номер четверти {quorter}");
      }